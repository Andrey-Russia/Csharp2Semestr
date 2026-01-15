using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Напишите ваш доход: ");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Расходы на аренду: ");
        double rent = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Расходы на еду: ");
        double food = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Расходы на транспорт: ");
        double transport = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("На сколько недель необходимо рассчитать бюджет? ");
        int weeks = Convert.ToInt32(Console.ReadLine());

        double totalTrats = rent + food + transport;

        double remainingMoney = income - totalTrats;

        double weeklyBudget = remainingMoney / weeks;

        if (weeklyBudget >= 100)
            Console.WriteLine($"Бюджет комфортный. Остаток на неделю: {weeklyBudget:F2}");
        else if (weeklyBudget >= 50 && weeklyBudget <= 99.99)
            Console.WriteLine($"Бюджет средний, нужно экономить. Остаток на неделю: {weeklyBudget:F2}");
        else Console.WriteLine($"Бюджет очень жесткий, придется сильно экономить. Остаток на неделю: {weeklyBudget:F2}");
    }
}