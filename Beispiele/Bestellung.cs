public class Bestellung
{
    private List<(string Name, decimal Stückpreis)> artikel;

    public string Kunde { get; }

    public int AnzahlArtikel => artikel.Count;

    public List<(string Name, decimal Stückpreis)> Artikel => artikel.ToList();

    public Bestellung(string kunde)
    {
        Kunde = kunde;
        artikel = new List<(string Name, decimal Stückpreis)>();
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
}