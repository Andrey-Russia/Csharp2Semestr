public interface ICraftRecipe<T> where T : Weapon
{
    bool CanCraft(Item a, Item b, Item c);
    T Craft(Item a, Item b, Item c);
}