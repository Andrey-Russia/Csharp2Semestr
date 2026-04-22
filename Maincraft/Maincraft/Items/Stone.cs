public class Stone : Item
{
    public Stone() : base(5.0, 0.8) { }

    public override string GetDescription()
        => $"Stone | Damage: {Damage}, Speed: {AttackSpeed}";
}