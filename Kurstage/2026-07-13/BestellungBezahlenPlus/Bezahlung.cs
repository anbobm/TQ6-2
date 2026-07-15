public abstract class Bezahlung : IBezahlung
{
    public abstract string BezahlForm { get; }

    public void Bezahlen(decimal betrag)
    {
        Console.WriteLine($"{betrag:F2} Euro {BezahlForm} bezahlt.");
    }
}