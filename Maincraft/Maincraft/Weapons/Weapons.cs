public class Weapon : Item
{
    public Element Element { get; private set; }

    public Weapon(double damage, double speed) : base(damage, speed) { }

    public void SetElement(Element element)
    {
        Element = element;
    }

    public void SetElement(Element a, Element b)
    {
        Element = a + b;
    }

    public override string GetDescription()
    {
        string elem = Element != null ? $" | Element: {Element.Name}" : "";
        return $"{GetType().Name} | DPS: {DPS}{elem}";
    }
}