using Maincraft.Items;
using Maincraft.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maincraft.Crafting
{
    public static class Workbench
    {
        public static Weapons.Weapons CraftSpear(Item item1, Item item2, Item item3)
        {
            if (item1 is Stone && item2 is Stick && item3 is Stick)
                return new Spear(item1, item2, item3);

            throw new ArgumentException("Недопустимый рецепт для копья");
        }


        public static Weapons.Weapons CraftAxe(Item item1, Item item2, Item item3)
        {
            if (item1 is Stone && item2 is Stone && item3 is Stick)
                return new Axe(item1, item2, item3);

            throw new ArgumentException("Недопустимый рецепт для топора");
        }
    }
}
