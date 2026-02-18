public abstract class Transport
{
    public Driver Pilot { get; private set; }
    public string Model { get; private set; }

    protected Transport(string model, Driver pilot)
    {
        Model = model;
        Pilot = pilot;
    }

    public virtual double MaxSpeed()
    {
        return 100 * (1 + Pilot.DriverSkill);
    }

    public abstract double FuelConsumption { get; }
    public abstract string TransportType { get; }
    public abstract void StartMoving();
}