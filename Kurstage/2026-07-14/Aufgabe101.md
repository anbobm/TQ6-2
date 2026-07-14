# Aufgabe 101

Erweitere die Klasse `Bestellung`, die bereits einen Konstruktor `Bestellung(string kunde)` besitzt, um einen weiteren Konstruktur, der neben dem `string kunde` auch noch eine Liste mit `(string Name, decimal Stückpreis)`-Tupeln erhält. Dieser neue Konstruktor macht es möglich, die Bestellung mit einer bereits vorhandenen Liste von Artikeln zu initialisieren.
Der Benutzer der Klasse `Bestellung` kann sich nun entscheiden, welcher Konstruktor besser geeignet ist.

Außerdem sollen beide Konstruktoren einen ILogger übergeben bekommen. Diesen soll die `Bestellung`-Klasse benutzen, um an geeigneten Stellen Änderungen zu protokollieren: beim Hinzufügen von Artikeln, beim Bezahlen und beim Erzeugen der Bestellung selbst.