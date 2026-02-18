public class Airplane : Transport, IExtremeTransport
{
    public Airplane(string model, Driver pilot)
        : base(model, pilot) { }

    public override double MaxSpeed()
    {
        return 800 * (1 + Pilot.DriverSkill);
    }

    public override double FuelConsumption => 40; 
    public override string TransportType => "Airplane";

    public bool CanDoStunts => true;                     
    public double RiskFactor => 0.7;                 

    public override void StartMoving()
    {
        Console.WriteLine($"{TransportType} {Model} взлетает.");
        Console.WriteLine($"MaxSpeed: {MaxSpeed()}\n");

        if (this is IExtremeTransport extreme)
            Console.WriteLine($"AirPlane сделал трюк: {extreme.PerformStunt()}");
    }

    public string PerformStunt()
    {
        return "Loop";                             
    }
}