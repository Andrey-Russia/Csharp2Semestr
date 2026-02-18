using SpaceProgram;
using System;
using System.Globalization;

namespace SpaceProgram
{
    public interface ISpace
    {
        double MaxAltitude { get; }
        public void TakeOff();
        public void Land();
    }

    public abstract class SpaceShip : ISpace
    {
        public string Name { get; set; }

        public abstract double MaxAltitude { get; }
        public abstract double CargoCpacity { get; }


        protected SpaceShip(string name)
        {
            this.Name = name;
        }

        public virtual void ActiveEngines()
        {
            Console.WriteLine($"{Name}: start");
        }

        public abstract void LaunchSquance();

        public void TakeOff()
        {
            ActiveEngines();
            LaunchSquance();
            Console.WriteLine($"{Name}: Взлет выполнен.");
        }

        public void Land()
        {
            Console.WriteLine($"{Name}: Посадка выполнена.");
        }
    }

    public class CargoShip : SpaceShip
    {
        public override double MaxAltitude => 12000;
        public override double CargoCpacity => 10000;

        public CargoShip(string name) : base(name) { }
        public override void LaunchSquance()
        {
            Console.WriteLine($"{Name}: Проверка грузовых отсеков...");
            Console.WriteLine($"{Name}: Запуск основной тяги...");
        }
    }

    public class Fighter : SpaceShip
    {
        public override double MaxAltitude => 12000;
        public override double CargoCpacity => 2000;

        public Fighter(string name) : base(name) { }

        public override void LaunchSquance()
        {
            Console.WriteLine($"{Name}: Активация боевых систем...");
            Console.WriteLine($"{Name}: Форсаж включен...");
        }
    }

    public class Shuttle : SpaceShip
    {
        public override double MaxAltitude => 120000;
        public override double CargoCpacity => 20000;

        public Shuttle(string name) : base(name) { }

        public override void LaunchSquance()
        {
            Console.WriteLine($"{Name}: Проверка систем жизнеобеспечения...");
            Console.WriteLine($"{Name}: Подключение орбитального модуля...");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        SpaceShip cargo = new CargoShip("Cargo - 1");
        SpaceShip fighter = new Fighter("Fighter - X");
        SpaceShip shuttle = new Shuttle("Shuttle - A");

        cargo.TakeOff();
        Console.WriteLine();

        fighter.TakeOff();
        Console.WriteLine();

        shuttle.TakeOff();
        Console.WriteLine();

        cargo.Land();
        fighter.Land();
        shuttle.Land();
    }
}