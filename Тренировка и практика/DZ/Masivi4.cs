//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Введите количесвто элементов масива: \t");

//        int elementsCount = int.Parse(Console.ReadLine());
//        int[] myArray = new int[elementsCount];
//        int minValue = myArray[0];

//        for (int i = 0; i < myArray.Length; i++)
//        {
//            Console.WriteLine($"\nВведите элемент масива под индексом {i}: \t");
//            myArray[i] = int.Parse(Console.ReadLine());
//        }

//        for (int i = 1; i < myArray.Length; i++)
//        {
//            if (myArray[i] < minValue)
//            {
//                minValue = myArray[i];
//            }
//        }
//        Console.WriteLine("Выод минимального значения: \n" + minValue);

//        Console.ReadLine();
//    }
//}