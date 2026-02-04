using System;

internal class Visa
{
    internal string _country {  get;private set; }
    internal bool _isValid { get;private set; }
    internal int _year {  get;private set; }

    public Visa()
    {
        Random random = new Random();
        string[] countries = { "Коленка", "Нога", "Голова" };
        _country = countries[random.Next(countries.Length)];
        _isValid = random.Next(2) == 1;
        _year = random.Next(2000, 2051);
    }

    internal void Showinfo()
    {
        Console.WriteLine($"Страна: {_country}");
        Console.WriteLine($"Подделка? {(_isValid ? "нет" : "да")}");
        Console.WriteLine($"Год: {_year}");
    }
}