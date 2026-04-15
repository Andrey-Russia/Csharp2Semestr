public class PhysicResistUnit : Unit
{
    private float _physicResist;
    private readonly Unit _baseUnit;

    public PhysicResistUnit(Unit unit, float physicDamageResist)
        : base(unit.Health, unit.Damage)
    {
        _baseUnit = unit;
        _physicResist = physicDamageResist;
    }

    public override void ApplyDamage(Damage damage)
    {
        float reducedPhysic = damage.PhysicDamage * (1 - _physicResist);
        float total = reducedPhysic + damage.MagicDamage + (damage.AbsoluteDamage ?? 0);

        Health -= total;
        if (Health < 0)
            Health = 0;
    }
}