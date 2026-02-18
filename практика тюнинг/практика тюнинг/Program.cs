using System;
using System.Threading.Channels;

class CarStats
{
    public double Power;
    public double Weight;
    public double DriverSkill;

    public double PowerDencity
    {
        get { return (Power / Weight) * DriverSkill; }
    }

    public CarStats(double power, double weight, double driverSkill)
    {
        Power = power;
        Weight = weight;
        DriverSkill = driverSkill;
    }

    public override string ToString()
    {
        return $"Мощность: {Power} л.с., Вес: {Weight} кг, Навык водителя: {DriverSkill}, Удельная мощность: {PowerDencity}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        CarStats Car1 = new CarStats(2000, 1000, 0.8);
        CarStats Car2 = new CarStats(3000, 2000, 0.2);

        Console.WriteLine("Первая машина:");
        Console.WriteLine(Car1);
        Console.WriteLine("\nВторая машина:");
        Console.WriteLine(Car2);

        double  totalPower = Car1.Power + Car2.Power;
        double resultPower = totalPower - (totalPower * 0.15);
        Console.WriteLine($"\nСложили мощности и вычли 15%: {resultPower}");

        double totalWeight = Car1.Weight + Car2.Weight;
        Console.WriteLine($"Сложили вес первой и второй машины: {totalWeight}");

        double averageSkill = (Car1.DriverSkill + Car2.DriverSkill) / 2;
        Console.WriteLine($"Среднее значение навыка водителя: {averageSkill}");
    }
}