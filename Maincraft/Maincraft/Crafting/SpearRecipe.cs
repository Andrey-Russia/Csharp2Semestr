public class SpearRecipe : ICraftRecipe<Spear>
{
    public bool CanCraft(Item a, Item b, Item c)
        => a is Stone && b is Stick && c is Stick;

    public Spear Craft(Item a, Item b, Item c)
    {
        double dmg = (a.Damage + b.Damage + c.Damage) * 1.2;
        double speed = (b.AttackSpeed + c.AttackSpeed) / 2;

        return new Spear(dmg, speed);
    }
}