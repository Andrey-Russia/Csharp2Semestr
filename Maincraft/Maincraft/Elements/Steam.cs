using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maincraft.Elements
{
    public sealed class Steam : Element
    {
        public float DamageRate { get; init; }

        public Steam(float combinedDamage)
        {
            SetDamage(combinedDamage);
        }
    }
}
