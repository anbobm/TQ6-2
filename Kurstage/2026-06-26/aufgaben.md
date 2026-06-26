# Aufgabe 1

Wie wir bereits wissen (siehe `Main`-Methode), können Methoden `static` sein. Das bedeutet sie gehören nicht zu einem bestimmten Objekt, sondern zur ganzen Klasse.

Das gleiche gibt es auch für Attribute. Ist ein Attribut `static`, dann wird dieser Wert für alle Objekte gleich sein. Betrachte folgendes Beispiel:

```csharp
public class Beispiel
{
    private static int bar;

    public void SetBar(int value)
    {
        bar = value;
    }

    public void Info()
    {
        Console.WriteLine($"bar ist {bar}");
    }
}

// in Main:

var b1 = new Beispiel();
var b2 = new Beispiel();

b1.Info();
b2.Info();

b1.SetBar(1);

b1.Info();
b2.Info();
```

Welche Ausgabe erwartest du? Überprüfe deine ob deine Erwartung zutrifft.

# Aufgabe 2

Erweitere die Klasse `Bestellung` so, dass sie ein (nur lesbares) Attribut `Bestellungsnummer` besitzen. Die erste Bestellung soll die Nummer `1` bekommen, die nächste die Nummer `2` usw.

Das soll automatisch passieren, also nicht dem Benutzer der Klasse überlassen werden.

*Tipp: Umsetzen lässt sich das mit einem statischen Feld innerhalb der Klasse Bestellung, welches im Konstruktor hochgezählt und im erzeugten Objekt gespeichert wird.