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

# Aufgabe 2

Erweitere die Klassen `Unternehmen` und `Abteilung` so, dass immer wenn eine Abteilung oder ein Mitarbeiter hinzugefügt oder entfernt wird, dies protokolliert wird. Dabei soll nicht direkt auf die Kommandozeile geschrieben werden, sondern es soll nur eine entsprechende Nachricht an eine andere Klasse übergeben werden.

Welche Klasse das konkret übernimmt, soll für `Unternehmen` und `Abteilung` keine Rolle spielen. Wichtig ist nur, dass das Interface `ILogger` mit der zugehörigen Methode `Log(string message)` bereitgestellt wird. Ein Objekt, das dieses Interface bereitstellt, sollen `Unternehmen` und `Abteilung` im Konstruktor erhalten.

Schreibe eine `ConsoleLogger` und eine `FileLogger` Klasse, die das `ILogger`-Interface implementieren.
`ConsoleLogger` soll auf die Kommandozeile schreiben, `FileLogger` in eine Datei eurer Wahl, z.B. `protokoll.log`.
Beide sollen beim protokollieren der Nachricht einen Zeitstempel voranstellen. (z.B. `DateTime.Now`)

Einer Datei Text anhängen geht zum Beispiel so:

```csharp
File.AppendAllText("foo.txt", "Das ist der Text");
```

Hinweis: Der Pfad im ersten Parameter ist relativ zum Arbeitsverzeichnis des kompilierten Programms.