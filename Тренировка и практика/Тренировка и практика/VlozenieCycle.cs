//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите высоту квадрата");
//        int height = int.Parse(Console.ReadLine());


//        for (int j = 0; j < height; j++)
//        {
//            for (int k = 0; k <= j; k++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }

//        Console.WriteLine();

//        for (int j = 0; j < height; j++)
//        {
//            for (int k = height; k > j; k--)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }

//        for (int j = 0; j < height; j++)
//        {
//            for (int k = height; k > j; k--)
//            {
//                Console.Write(" ");
//            }
//            for (int k = 0; k <= j; k++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }

//        Console.WriteLine();

//        for (int j = 0; j < height; j++)
//        {
//            for (int k = 0; k <= j; k++)
//            {
//                Console.Write(" ");
//            }
//            for (int k = height; k > j; k--)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }

//        Console.WriteLine("Введите ширину квадрата");
//        int weight = int.Parse(Console.ReadLine());
//        for (int i = 0; i < count; i++)
//        {
//            for (int j = 0; j < height; j++)
//            {
//                for (int k = 0; k < weight; k++)
//                {
//                    Console.Write("#");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//        }

//        Console.ReadLine();
//    }
//}