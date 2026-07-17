## Aufgabe 105 - Testergebnisse

Schreibe für die Klasse `VendingMachine` zuerst alle Tests, und implementiere danach die Klasse.

```
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

### Verhalten der Klasse VendingMachine

#### InsertMoney(decimal amount)

Der Benutzer wirft Geld ein. Nur positive Beträge sind erlaubt. Der eingeworfene Betrag wird zum Guthaben addiert. Das neue Guthaben wird zurückgegeben.

#### BuyDrink()

Ist genügend Guthaben vorhanden, mindestens 2,50 €, wird das Getränk verkauft. 2,50 € werden vom Guthaben abgezogen. Die Methode liefert `true`.

Ist nicht genügend Guthaben vorhanden, passiert nichts. Die Methode liefert `false`.

#### ReturnMoney()

Der Automat gibt das komplette Restguthaben zurück. Danach ist das Guthaben 0 €.

### Testfälle

#### Anfangszustand

Das Guthaben ist anfangs 0 €.

#### Geld einwerfen

1 € erhöht das Guthaben. Mehrere Einzahlungen werden addiert. 0 € und negative Beträge sind nicht erlaubt.

#### Getränk kaufen

Kauf mit genau 2,50 € funktioniert. Kauf mit mehr Guthaben funktioniert. Restguthaben bleibt erhalten. Kauf mit zu wenig Guthaben schlägt fehl. Mehrere Getränke können hintereinander gekauft werden.

#### Geld zurückgeben

Restguthaben wird korrekt zurückgegeben. Danach ist das Guthaben 0 €. Wenn kein Guthaben vorhanden ist, wird 0 € zurückgegeben.

### Testergebnisse

Während der Implementierung wurden die Tests schrittweise geschrieben und ausgeführt. Fehlgeschlagene Tests zeigten jeweils, welche Methode noch nicht vollständig implementiert war.

Beispiele für fehlgeschlagene Tests vor der Korrektur:

```
System.NotImplementedException
```

```
Expected: False
Actual:   True
```

```
Expected: 0,00
Actual:   4,20
```

Nach der vollständigen Implementierung wurden alle Tests erfolgreich ausgeführt.

```
Test Summary: total: 12; failed: 0; passed: 12; skipped: 0
Build succeeded
```

### Ergebnis

Aufgabe105 ist korrekt gelöst.