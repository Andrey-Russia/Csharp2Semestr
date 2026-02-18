public class Taxi : Transport
{
    public Taxi(string model, Driver pilot)
        : base(model, pilot) { }

    public override double FuelConsumption => 6;
    public override string TransportType => "Taxi";

    public override void StartMoving()
    {
        Console.WriteLine($"{TransportType} {Model} начинает движение.");
        Console.WriteLine($"MaxSpeed: {MaxSpeed()}\n");
    }
}