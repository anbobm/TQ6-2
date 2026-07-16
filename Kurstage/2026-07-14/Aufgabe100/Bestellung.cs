public class Bestellung
{
    private static int letzteBestellungsnummer;
    public int Bestellungsnummer { get; }
    private List<(string Name, decimal Stückpreis)> artikel;

    public string Kunde { get; }

    public int AnzahlArtikel => artikel.Count;

    public List<(string Name, decimal Stückpreis)> Artikel => artikel.ToList();

    public Bestellung(string kunde)
    {
        Kunde = kunde;
        artikel = new List<(string Name, decimal Stückpreis)>();
        Bestellungsnummer = ++letzteBestellungsnummer;
    }

    public void ArtikelHinzufügen(string name, decimal stückpreis)
    {
        artikel.Add((name, stückpreis));
    }

    public decimal Gesamtpreis
    {
        get
        {
            decimal summe = 0;
            foreach (var artikel in artikel)
            {
                summe += artikel.Stückpreis;
            }

            return summe;

            // // Alternative mit Linq
            // return artikel.Sum(artikel => artikel.Stückpreis);
        }
    }

    public void BestellungBezahlen(IBezahlung bezahlung, IRabatt rabatt)
    {
        var abzug = rabatt.RabattBerechnen(Gesamtpreis);
        bezahlung.Bezahlen(Gesamtpreis - abzug);
    }
}
