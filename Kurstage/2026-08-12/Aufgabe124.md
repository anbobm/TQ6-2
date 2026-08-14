# Aufgabe 124

## Aufgabe

Die Datenbank wurde um die Tabelle `Exemplare` erweitert.

Jedes Exemplar hat die Eigenschaften `Id`, `IstAusgeliehen` und `BuchId`.
`BuchId` verweist auf das zugehörige Buch.

Die Page `/BuchDetail` zeigt die Exemplare des ausgewählten Buches an.

## Ergebnis

Die Detailseite von „Die Räuber“ unter `/BuchDetail?id=12` zeigt zwei Exemplare:

- Exemplar 4: verfügbar
- Exemplar 5: ausgeliehen

Für ein Buch ohne Exemplare wird `keine Exemplare vorhanden` angezeigt.