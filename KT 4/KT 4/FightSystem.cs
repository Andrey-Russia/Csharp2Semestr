public class FightSystem
{
    public List<Unit> LeftTeam { get; private set; }
    public List<Unit> RightTeam { get; private set; }

    private int _leftIndex = 0;
    private int _rightIndex = 0;

    private Unit leftCurrentUnit;
    private Unit rightCurrentUnit;

    public FightSystem(List<Unit> left, List<Unit> right)
    {
        LeftTeam = left;
        RightTeam = right;

        leftCurrentUnit = LeftTeam[0];
        rightCurrentUnit = RightTeam[0];
    }

    public void NextUnit(List<Unit> team, ref int index, ref Unit current)
    {
        int startIndex = index;

        do
        {
            index = (index + 1) % team.Count;
            current = team[index];

            if (current.IsAlive)
                return;

        } while (index != startIndex);
    }

    public float GetTeamHP(List<Unit> team)
    {
        return team.Sum(u => u.Health);
    }

    public void ManageFight(out int totalHits, out float totalDamage)
    {
        totalHits = 0;
        totalDamage = 0;

        while (GetTeamHP(LeftTeam) > 0 && GetTeamHP(RightTeam) > 0)
        {
            if (leftCurrentUnit.IsAlive)
            {
                leftCurrentUnit.TakeDamage(rightCurrentUnit, out float dmg);
                totalDamage += dmg;
                totalHits++;
            }

            if (rightCurrentUnit.IsAlive)
            {
                rightCurrentUnit.TakeDamage(leftCurrentUnit, out float dmg);
                totalDamage += dmg;
                totalHits++;
            }

            Console.WriteLine($"Left HP: {GetTeamHP(LeftTeam)} | Right HP: {GetTeamHP(RightTeam)}");

            NextUnit(LeftTeam, ref _leftIndex, ref leftCurrentUnit);
            NextUnit(RightTeam, ref _rightIndex, ref rightCurrentUnit);
        }
    }
}