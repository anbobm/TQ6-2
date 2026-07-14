using System;

public class KreditkartenBezahlung : IBezahlung
{
    public void Bezahlen(decimal betrag)
    {
        Console.WriteLine($"{betrag:F2} Euro mit Kreditkarte bezahlt.");
    }
}