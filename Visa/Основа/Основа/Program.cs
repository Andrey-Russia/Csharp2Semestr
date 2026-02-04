using System;

internal class Program
{
    static void Main()
    {
        Visa[] visas = new Visa[3];
        for (int i = 0; i < visas.Length; i++)
        {
            visas[i] = new Visa();
            visas[i].Showinfo();

            BorderGuard borderGuard = new BorderGuard();
            string result = borderGuard.CheckVisa(visas[i]);
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}

