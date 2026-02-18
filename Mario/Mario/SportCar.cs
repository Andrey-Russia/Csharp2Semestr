public class SportsCar : Transport, IExtremeTransport
{
    public SportsCar(string model, Driver pilot)
        : base(model, pilot) { }

    public override double MaxSpeed()
    {
        return base.MaxSpeed() * 1.5;
    }

    public override double FuelConsumption => 15;
    public override string TransportType => "SportsCar";

    public bool CanDoStunts => true;               
    public double RiskFactor => 0.4;

    public override void StartMoving()
    {
        Console.WriteLine($"{TransportType} {Model} стартует!");
        Console.WriteLine($"MaxSpeed: {MaxSpeed()} \n");

        if (this is IExtremeTransport extreme)
            Console.WriteLine($"SportCar сделал трюк: {extreme.PerformStunt()}");
    }

    public string PerformStunt()
    {
        return "Drift";                          
    }
}