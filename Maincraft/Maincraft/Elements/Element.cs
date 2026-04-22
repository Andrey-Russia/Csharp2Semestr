public abstract class Element
{
    public float Damage { get; protected set; }
    public string Name { get; protected set; }

    public static Element operator +(Element a, Element b)
    {
        if ((a is Fire && b is Ice) || (a is Ice && b is Fire))
        {
            return new Steam((a.Damage + b.Damage) * 1.2f);
        }

        throw new Exception("Invalid element combination");
    }
}