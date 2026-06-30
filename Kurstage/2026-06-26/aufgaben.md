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

*Tipp: Umsetzen lässt sich das mit einem statischen Feld innerhalb der Klasse Bestellung, welches im Konstruktor hochgezählt und im erzeugten Objekt gespeichert wird.*


# Aufgabe 3

Schreibe eine Klasse `Bankkonto` mit den Attributen `Inhaber` (`string`), `Kontonummer` (`string`), `Kontostand` (`decimal`) und einem statischen Attribut `Zinssatz` (`decimal`). Der Zinssatz soll geschrieben werden können, darf aber nicht negativ sein.

Es soll seine Methode `ZinsenAuszahlen()` geben, die den Kontostand um die Zinsen (Kontostand * Zinssatz) erhöht, und eine Methode `Info()` die den Zustand des Kontos ausgibt.

Führe anschließend den folgenden Beispielcode aus und überprüfe ob die Resultate deinen Erwartungen entsprechen.

```csharp
var konto1 = new Konto("Sabine", "DE32 5923 4661 5717 5712 32", 1000.0m);
var konto2 = new Konto("Petra", "DE17 1128 3712 3128 7931 09", 100000.0m);
var konto1 = new Bankkonto("Sabine", "DE32 5923 4661 5717 5712 32", 1000.0m);
var konto2 = new Bankkonto("Petra", "DE17 1128 3712 3128 7931 09", 100000.0m);

Bankkonto.Zinssatz = 0.1m;
konto1.ZinsenAuszahlen();
@@ -63,7 +63,9 @@
konto2.Info();

Bankkonto.Zinssatz = 0.2m;
konto1.ZinsenAuszahlen();
konto2.ZinsenAuszahlen();

konto1.Info();
konto1.Info();
konto2.Info();