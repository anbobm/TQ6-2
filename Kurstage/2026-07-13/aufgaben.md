# Aufgabe 1

Erweitere die Klasse `Bestellung.cs` aus der früheren Aufgabe so, dass sie eine Methode `BestellungBezahlen(IBezahlung bezahlung)` besitzt. Am Typ des Paramteres `bezahlung` zu erkennen, erhält die Methode ein Objekt, dessen Klasse das `IBezahlung` Interface implementiert.

Dieses Interface soll eine Methode `Bezahlen(decimal betrag)` besitzen.

Schreibe drei Klassen, die dieses Interface implementieren: `KreditkartenBezahlung`, `PayPalBezahlung`, `BarZahlung`. Die Implementierung simulieren wir nur, indem wir einen entsprechenden String auf die Kommandozeile ausgeben, z.B. `xx.xx € mit PayPal bezahlt.`.

Rufe anschließend eine Beispiel-Bestellung jeweils mit Objekten dieser drei Klassen als Parameter auf, um das Ganze zu testen.

```csharp
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
}
```