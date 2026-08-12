# Aufgabe 124

Erweitere die Datenbank um eine Tabelle `Exemplare`. Zu jedem Datensatz in `Bücher` kann es ein oder mehrere Exemplare geben (oder kein Exemplar). Jedes Exemplar hat eine `Id`, ein Attribut `IstAusgeliehen` und eine Referenz auf ein `Buch`, zu dem es gehört.

Ergänze die Page `/BuchDetail` um eine Auflistung der Exemplare, die zu dem angezeigten Buch gehören.