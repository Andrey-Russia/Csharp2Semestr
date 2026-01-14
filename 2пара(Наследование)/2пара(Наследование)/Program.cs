using System;
using System.Security.Claims;

public abstract class Animal
{
    public string Name { get; set; }
    public int age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        this.age = age;
    }

    public abstract void MakeSound();
}

public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Гав");
    }
}

public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Мяу");
    }
}

class Program
{
    static void Main()
    {
        var dog = new Dog("ddd", 3);
        dog.MakeSound();
        var cat = new Cat("hhh", 2);
        cat.MakeSound();
    }
}