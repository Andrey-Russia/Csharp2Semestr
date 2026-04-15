public class DoubleResistUnit : Unit
{
    private float _physicResist;
    private float _magicResist;

    public DoubleResistUnit(Unit unit, float physicDamageResist, float magicDamageResist)
        : base(unit.Health, unit.Damage)
    {
        _physicResist = physicDamageResist;
        _magicResist = magicDamageResist;
    }

    public DoubleResistUnit(PhysicResistUnit unit, float magicDamageResist)
        : base(unit.Health, unit.Damage)
    {
        _physicResist = 0.3f;
        _magicResist = magicDamageResist;
    }

    public DoubleResistUnit(MagicResistUnit unit, float physicDamageResist)
        : base(unit.Health, unit.Damage)
    {
        _physicResist = physicDamageResist;
        _magicResist = 0.3f;
    }

    public override void ApplyDamage(Damage damage)
    {
        float reducedPhysic = damage.PhysicDamage * (1 - _physicResist);
        float reducedMagic = damage.MagicDamage * (1 - _magicResist);

        float total = reducedPhysic + reducedMagic + (damage.AbsoluteDamage ?? 0);

        Health -= total;
        if (Health < 0)
            Health = 0;
    }
}