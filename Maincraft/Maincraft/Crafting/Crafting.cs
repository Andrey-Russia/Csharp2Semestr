public class Workbench
{
    private readonly Dictionary<Type, object> _recipes;

    public Workbench(
        ICraftRecipe<Spear> spear,
        ICraftRecipe<Axe> axe)
    {
        _recipes = new Dictionary<Type, object>
            {
                { typeof(Spear), spear },
                { typeof(Axe), axe }
            };
    }

    public T Craft<T>(Item a, Item b, Item c) where T : Weapon
    {
        if (!_recipes.TryGetValue(typeof(T), out var recipeObj))
            throw new Exception("Recipe not found");

        var recipe = (ICraftRecipe<T>)recipeObj;

        if (!recipe.CanCraft(a, b, c))
            throw new Exception("Invalid ingredients");

        return recipe.Craft(a, b, c);
    }
}