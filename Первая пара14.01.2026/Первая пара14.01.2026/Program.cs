using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите своё ФИО");
        string fullName = Console.ReadLine();

        int[] grades = new int[5];

        for (int i = 0; i < 5; i++)
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.Write($"Оценка {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int grade))
                {
                    if (grade >= 2 && grade <= 5)
                    {
                        grades[i] = grade;
                        validInput = true;
                    }
                    else
                        Console.WriteLine("Ошибка: Оценка должна быть целым числом от 2 до 5!");
                }
            }
        }

        double Score = CalculateScore(grades);

        int minGrade = FindMin(grades);
        int maxGrade = FindMax(grades);

        string finalGrade = GetFinalGrade((int)Math.Round(Score));

        Console.WriteLine($"\nФИО ученика: {fullName}");
        Console.WriteLine($"Средняя оценка: {Score}");
        Console.WriteLine($"Минимальная оценка: {minGrade}");
        Console.WriteLine($"Максимальная оценка: {maxGrade}");
        Console.WriteLine($"Итоговая оценка: {finalGrade}");
    }

    private static double CalculateScore(int[] grades)
    {
        return grades.Average();
    }

    private static int FindMin(int[] grades)
    {
        return grades.Min();
    }

    private static int FindMax(int[] grades)
    {
        return grades.Max();
    }

    private static string GetFinalGrade(int fff)
    {
        switch(fff)
        {
            case 5:
                return "Отлично";
            case 4:
                return "Хорошо";
            case 3:
                return "Удолетварительно";
            default:
                return "Плохо";
        }
    }
}