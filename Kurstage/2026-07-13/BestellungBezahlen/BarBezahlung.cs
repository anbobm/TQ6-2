public class BarBezahlung : IBezahlung
{
    public void Bezahlen(decimal betrag)
    {
        Console.WriteLine($"{betrag} € in bar bezahlt");
    }
}