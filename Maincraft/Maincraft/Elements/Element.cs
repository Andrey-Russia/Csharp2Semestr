using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maincraft.Elements
{
    public abstract class Element
    {
        public float Damage { get; protected set; }

        protected void SetDamage(float value)
        {
            Damage = value;
        }

        public static Element operator +(Element element1, Element element2)
        {
            if (element1 is Fire fire && element2 is Ice ice)
            {
                return new Steam(fire.Damage + ice.Damage + 20);
            }
            else if (element1 is Ice ice2 && element2 is Fire fire2)
            {
                return new Steam(ice2.Damage + fire2.Damage + 20);
            }
            else
            {
                throw new InvalidOperationException("Невозможно объединить указанные элементы.");
            }
        }
    }
}
