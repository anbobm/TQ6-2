using System;

public class BarBezahlung : IBezahlung
{
    public void Bezahlen(decimal betrag)
    {
        Console.WriteLine($"{betrag:F2} Euro bar bezahlt.");
    }
}