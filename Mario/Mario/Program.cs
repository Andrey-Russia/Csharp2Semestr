class Program
{
    static void Main(string[] args)
    {
        Driver driver = new GameDriver("Mario", 0.8);

        Transport car = new SportsCar("Ferrari", driver);
        Transport taxi = new Taxi("Toyota", driver);
        Transport plane = new Airplane("Boeing", driver);

        car.StartMoving();                               
        taxi.StartMoving();
        plane.StartMoving();

        Console.WriteLine();

        IExtremeTransport extreme = car as IExtremeTransport; 
        if (extreme != null)
        {
            Console.WriteLine("Трюк: " + extreme.PerformStunt()); 
        }
    }
}