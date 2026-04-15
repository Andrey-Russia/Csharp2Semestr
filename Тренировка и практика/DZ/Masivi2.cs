//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Введите количесвто элементов масива: \t");

//        int elementsCount = int.Parse(Console.ReadLine());
//        int[] myArray = new int[elementsCount];

//        for (int i = 0; i < myArray.Length; i++)
//        {
//            Console.WriteLine($"\nВведите элемент масива под индексом {i}: \t");
//            myArray[i] = int.Parse(Console.ReadLine());
//        }
//        Console.WriteLine("Вывод масива: ");

//        for (int i = myArray.Length - 1; i >= 0; i--)
//        {
//            Console.WriteLine(myArray[i]);
//        }

//        Console.ReadLine();
//    }
//}