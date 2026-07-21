public class KreditkartenBezahlung : IBezahlung
{
    public void Bezahlen(decimal betrag)
    {
        Console.WriteLine($"{betrag} mit Kreditkarte bezahlt");
    }
}