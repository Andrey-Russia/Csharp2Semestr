public class Stick : Item
{
    public Stick() : base(2.0, 1.2) { }

    public override string GetDescription()
        => $"Stick | Damage: {Damage}, Speed: {AttackSpeed}";
}