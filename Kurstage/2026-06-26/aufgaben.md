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