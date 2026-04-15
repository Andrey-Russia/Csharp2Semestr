public class MagicResistUnit : Unit
{
    private float _magicResist;
    private readonly Unit _baseUnit;

    public MagicResistUnit(Unit unit, float magicDamageResist)
        : base(unit.Health, unit.Damage)
    {
        _baseUnit = unit;
        _magicResist = magicDamageResist;
    }

    public override void ApplyDamage(Damage damage)
    {
        float reducedMagic = damage.MagicDamage * (1 - _magicResist);
        float total = damage.PhysicDamage + reducedMagic + (damage.AbsoluteDamage ?? 0);

        Health -= total;
        if (Health < 0)
            Health = 0;
    }
}