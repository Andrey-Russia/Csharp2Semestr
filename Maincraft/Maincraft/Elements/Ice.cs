using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maincraft.Elements
{
    public sealed class Ice: Element
    {
        public float DamageRate { get; init; }

        public Ice (float damageRate)
        {
            this.DamageRate = damageRate;
            SetDamage(damageRate * 10);
        }
    }
}
