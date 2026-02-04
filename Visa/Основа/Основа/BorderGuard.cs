using System;
using System.Data;

internal class BorderGuard
{
    internal string CheckVisa(Visa visa)
    {
        if (visa._country != "Коленка" && visa._country != "Нога")
            return "Въезд запрещён";
        if (!visa._isValid)
            return "Въезд запрещён";
        int currentYear = 2026;
        if (currentYear - visa._year > 5 && visa._year <= currentYear)
            return "Въезд запрещён";

        return "Въезд разрешён";
    }
}

