public class Program
{
    static void Main()
    {
        var leftTeam = new List<Unit>
        {
            new Warrior(),                         
            new PhysicResistUnit(new Mage(), 0.3f), 
            new Healer()                           
        };

        var rightTeam = new List<Unit>
        {
            new MagicResistUnit(new Warrior(), 0.2f),
            new Mage(),
            new DoubleResistUnit(new Healer(), 0.2f, 0.2f)
        };


        var fight = new FightSystem(leftTeam, rightTeam);

        Console.WriteLine("=== FIGHT START ===");

        fight.ManageFight(out int hits, out float damage);

        Console.WriteLine("\n=== RESULT ===");
        Console.WriteLine($"Total hits: {hits}");
        Console.WriteLine($"Total damage: {damage}");
    }
}