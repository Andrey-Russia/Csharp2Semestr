using Maincraft.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maincraft.Weapons
{
    public abstract class Weapons : Item
    {
        protected Weapons(double damage, double attackSpeed) : base(damage, attackSpeed) { }

        public override string GetDescription()
        {
            return $"Оружие:{base.GetDescription()}";
        }
    }
}
