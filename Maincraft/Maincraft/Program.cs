using Maincraft.Items;
using Maincraft.Weapons;
using Maincraft.Crafting;

class Programm
{
    static void Main(string[] args)
    {
        var stone = new Stone();
        var stick1 = new Stick();
        var stick2 = new Stick();

        try
        {
            var spear = Workbench.CraftSpear(stone, stick1, stick2);
            Console.WriteLine(spear.GetDescription());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            var axe = Workbench.CraftAxe(new Stone(), new Stone(), new Stick());
            Console.WriteLine(axe.GetDescription());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}