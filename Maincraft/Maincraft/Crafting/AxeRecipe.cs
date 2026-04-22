public class AxeRecipe : ICraftRecipe<Axe>
{
    public bool CanCraft(Item a, Item b, Item c)
        => a is Stone && b is Stone && c is Stick;

    public Axe Craft(Item a, Item b, Item c)
    {
        double dmg = (a.Damage + b.Damage + c.Damage) * 1.5;
        double speed = (a.AttackSpeed + b.AttackSpeed + c.AttackSpeed) / 3;

        return new Axe(dmg, speed);
    }
}