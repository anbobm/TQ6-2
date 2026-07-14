using System;

public class PayPalBezahlung : IBezahlung
{
    public void Bezahlen(decimal betrag)
    {
        Console.WriteLine($"{betrag:F2} Euro mit PayPal bezahlt.");
    }
}