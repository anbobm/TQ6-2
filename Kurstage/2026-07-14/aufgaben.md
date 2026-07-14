# Aufgabe 1

Erweitere die Methode `BestellungBezahlen()` der Klasse `Bestellung` um einen Parameter `rabatt` des Typs `IRabatt`.

Das Interface `IRabatt` definiert eine Methode `RabattBerechnen()`, die einen Gesamtpreis erhält und daraus den Rabatt berechnet.

Drei Klassen sollen dieses Interface implementieren: `StudentenRabatt`, `SeniorenRabatt` und `KeinRabatt`.