/*using System;

class Program
{
    static void Main(string[] args)
    {

        double result;

        Console.WriteLine("Ввдеите значение 1: ");
        double firstValue = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение 2:");
        double secondValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Введиите одну из следующих операций: + - * / ");
        string operation = Console.ReadLine();

        switch(operation)
        {
            case "+":
                result = firstValue + secondValue;
                Console.WriteLine("Сумма чисел равна: " + result);
                    break;
            case "-":
                result = firstValue - secondValue;
                Console.WriteLine("Разность чисел равна: " + result);
                break;
            case "*":
                result = firstValue * secondValue;
                Console.WriteLine("Произведение равно: " + result);
                break;
            case "/":
                if (secondValue == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    result = firstValue / secondValue;
                    Console.WriteLine("Результат равен: " + result);
                }
                break;
            default:
                Console.WriteLine("Неизвестное действие!");
                break;
        }
    }
}*/