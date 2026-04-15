using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maincraft.Items
{
    public abstract class Item
    {
        public double Damage { get; protected set; }
        public double AttackSpeed { get; protected set; }

        public virtual double DPS => Damage * AttackSpeed;

        protected Item(double damage, double attackSpeed)
        {
            Damage = damage;
            AttackSpeed = attackSpeed;
        }
        public virtual  string GetDescription()
        {
            return $"Тип: {GetType().Name}. Урон: {Damage:F1}. Скорость атаки: {AttackSpeed}. DPS: {DPS}";
        }
    }
}
