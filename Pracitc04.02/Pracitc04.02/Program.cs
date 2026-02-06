using System;

class Program
{
    static void Main(string[] args)
    {
        Goblin goblin = new Goblin { Damage = 10, PoisonDamage = 5 };
        Ork ork = new Ork { Damage = 20, CritRate = 2 };
        Dragon dragon = new Dragon { Damage = 100, DamageArea = 20, FireDamage = 10 };


        int goblinDamage = goblin.TakeDamage();
        int orfDamage = ork.TakeDamage();
        int dragonDamage = dragon.TakeDamage();

        Console.WriteLine($"{goblinDamage}");
        Console.WriteLine($"{orfDamage}");
        Console.WriteLine($"{dragonDamage}");
    }
}