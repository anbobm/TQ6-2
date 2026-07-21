public class PayPalBezahlung : IBezahlung
{
    public void Bezahlen(decimal betrag)
    {
        Console.WriteLine($"{betrag} mit PayPal bezahlt");
    }
}