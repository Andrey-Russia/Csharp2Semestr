public class Damage
{
    public float PhysicDamage { get; private set; }
    public float MagicDamage { get; private set; }
    public float? AbsoluteDamage { get; private set; }

    public Damage(float physicDamage, float magicDamage, float? absoluteDamage = null)
    {
        PhysicDamage = physicDamage;
        MagicDamage = magicDamage;
        AbsoluteDamage = absoluteDamage;
    }

    public float GetTtotalDamage()
    {
        return PhysicDamage + MagicDamage + (AbsoluteDamage ?? 0);
    }
}