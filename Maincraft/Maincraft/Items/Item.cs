public abstract class Item
{
        public double Damage { get; protected set; }
        public double AttackSpeed { get; protected set; }

        public double DPS => Damage * AttackSpeed;

        protected Item(double damage, double attackSpeed)
        {
            Damage = damage;
            AttackSpeed = attackSpeed;
        }

        public abstract string GetDescription();
}
