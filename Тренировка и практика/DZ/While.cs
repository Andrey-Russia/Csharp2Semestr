/*using System;

class Program
{
    static void Main(string[] args)
    {
        uint oddNumbers = 0;
        uint evenNumbers = 0;

        int oddSum = 0;
        int evenSum = 0;

        Console.WriteLine("Введите первое число диапазона");
        int currentValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите последнее число диапозона");
        int limit = int.Parse(Console.ReadLine());

        while (currentValue <= limit)
        {
            if (currentValue % 2 == 0)
            {
                evenNumbers++;
                evenSum += currentValue;
            }
            else
            {
                oddSum = oddSum + currentValue;
                oddNumbers++;
            }
            currentValue++;
        }

        Console.WriteLine("Количество нечётных чисел: " + oddNumbers);
        Console.WriteLine("Сумма нечётных чисел: " + oddSum);
        Console.WriteLine("\nКоличество чётных чисел: " + evenNumbers);
        Console.WriteLine("Сумма чётных чисел: " + evenSum);
        Console.ReadLine();
    }
}*/