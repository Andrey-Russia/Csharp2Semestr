using Maincraft.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maincraft.Weapons
{
    public class Axe : Weapons
    {
        private readonly Item _stone;
        private readonly Item _stick1;
        private readonly Item _stick2;

        public Axe(Item stone, Item stick1, Item stick2) : base(
            damage: (stone.Damage + stick1.Damage + stick2.Damage) * 1.5,
            attackSpeed: (stick1.AttackSpeed + stick2.AttackSpeed) / 4)
        {
            _stone = stone;
            _stick1 = stick1;
            _stick2 = stick2;
        }
    }
}