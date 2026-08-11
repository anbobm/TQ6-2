# Aufgabe 120

Erweitere `BiboApp` um eine Page `/Autoren`. Füge einen Link im Layout hinzu, der auf diese Page verweist.

Erstelle eine Klasse `Autor` mit `Id` und `Name`. Füge dem `DbContext` eine Property `Autoren` vom Typ `DbSet<Autor>`.

Ergänze die `bibo.db` entsprechend um eine Tabelle `Autoren` und fülle sie mit Daten.

(Die Tabelle `Bücher` hat bis jetzt eine `Autor`-Spalte die ein String ist. Diese werden wir bald durch eine Referenz auf die neue Tabelle ersetzen.)

Die Page `/Autoren` soll alle Autoren aus der Datenbank in einer `<ul>` anzeigen.