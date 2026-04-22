class Program
{
    static void Main()
    {
        var workbench = new Workbench(
            new SpearRecipe(),
            new AxeRecipe()
        );

        Item stone1 = new Stone();
        Item stone2 = new Stone();
        Item stick1 = new Stick();
        Item stick2 = new Stick();

        List<Weapon> weapons = new List<Weapon>();

        Weapon spear = workbench.Craft<Spear>(stone1, stick1, stick2);
        Weapon axe = workbench.Craft<Axe>(stone1, stone2, stick1);

        weapons.Add(spear);
        weapons.Add(axe);

        spear.SetElement(new Fire(10));
        axe.SetElement(new Ice(8), new Fire(6)); 

        Console.WriteLine("=== WEAPONS INFO ===\n");

        foreach (var weapon in weapons)
        {
            Console.WriteLine(weapon.GetDescription());
        }
    }
}