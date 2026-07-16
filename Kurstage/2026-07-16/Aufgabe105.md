# Aufgabe 105

Schreibe für die Klasse `VendingMachine` zuerst alle Tests, und implementiere danach die Klasse.

```csharp
public class VendingMachine
{
    public decimal InsertMoney(decimal amount)
    {
    }

    public bool BuyDrink()
    {
    }

    public decimal ReturnMoney()
    {
    }

    public decimal CurrentBalance { get; }
}
```

## Verhalten der Klasse `VendingMachine`

### `InsertMoney(decimal amount)`

Der Benutzer wirft Geld ein.

* Nur positive Beträge sind erlaubt.
* Der eingeworfene Betrag wird zum Guthaben addiert.
* Das neue Guthaben wird zurückgegeben.

### `BuyDrink()`

Ist genügend Guthaben vorhanden (mindestens 2,50 €):

* Das Getränk wird verkauft.
* 2,50 € werden vom Guthaben abgezogen.
* Die Methode liefert true.

Ist nicht genügend Guthaben vorhanden:

* Es passiert nichts.
* Die Methode liefert false.

### `ReturnMoney()`

Der Automat gibt das komplette Restguthaben zurück.

Beispiel:

```
Guthaben: 4,20 €

ReturnMoney()

-> Rückgabe: 4,20 €
-> Neues Guthaben: 0 €
```

## Testfälle

### Anfangszustand

Guthaben ist anfangs 0 €.

### Geld einwerfen

* 1 € erhöht das Guthaben.
* Mehrere Einzahlungen werden addiert.
* 0 € ist nicht erlaubt.
* Negative Beträge sind nicht erlaubt.

### Getränk kaufen

* Kauf mit genau 2,50 € funktioniert.
* Kauf mit mehr Guthaben funktioniert.
* Restguthaben bleibt erhalten.
* Kauf mit zu wenig Guthaben schlägt fehl.
* Mehrere Getränke hintereinander kaufen.

### Geld zurückgeben

* Restguthaben wird korrekt zurückgegeben.
* Danach ist das Guthaben 0 €.
* Geld zurückgeben, obwohl kein Guthaben vorhanden ist.