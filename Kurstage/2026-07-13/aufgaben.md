# Aufgabe 1

Erweitere die Klasse `Bestellung.cs` aus der früheren Aufgabe so, dass sie eine Methode `BestellungBezahlen(IBezahlung bezahlung)` besitzt. Am Typ des Paramteres `bezahlung` zu erkennen, erhält die Methode ein Objekt, dessen Klasse das `IBezahlung` Interface implementiert.

Dieses Interface soll eine Methode `Bezahlen(decimal betrag)` besitzen.

Schreibe drei Klassen, die dieses Interface implementieren: `KreditkartenBezahlung`, `PayPalBezahlung`, `BarZahlung`. Die Implementierung simulieren wir nur, indem wir einen entsprechenden String auf die Kommandozeile ausgeben, z.B. `xx.xx € mit PayPal bezahlt.`.

Rufe anschließend eine Beispiel-Bestellung jeweils mit Objekten dieser drei Klassen als Parameter auf, um das ganze zu testen.