using System;

internal abstract class Creature
{
    protected int Damage { get; private set; }

    public virtual int TakeDamage()
    {
        return Damage;
    }
}

internal class Goblin : Creature
{
    protected int PoisonDamage { get; private set; }

    public override int TakeDamage()
    {
        return base.TakeDamage() + PoisonDamage;
    }
}
internal class Ork : Creature
{
    protected int CritRate { get; set; }

    public override int TakeDamage()
    {
        return base.TakeDamage() * CritRate;
    }
}

internal class Dragon : Creature
{
    protected int DamageArea { get; set; }
    protected int FireDamage { get; set; }

    public override int TakeDamage()
    {
        return base.TakeDamage() + DamageArea + FireDamage;
    }
}