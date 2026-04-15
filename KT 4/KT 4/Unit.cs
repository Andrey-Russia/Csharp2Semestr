public class Unit
{
    public float Health { get; protected set; }
    public Damage Damage { get; private set; }

    public bool IsAlive => Health > 0;

    public Unit(float health, Damage damage)
    {
        Health = health;
        Damage = damage;
    }

    public virtual void TakeDamage(Unit target, out float dealtDamage)
    {
        dealtDamage = Damage.GetTtotalDamage();
        target.ApplyDamage(Damage);
    }

    public virtual void ApplyDamage(Damage damage)
    {
        Health -= damage.GetTtotalDamage();
        if (Health < 0)
            Health = 0;
    }
}