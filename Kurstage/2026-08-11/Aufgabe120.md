# Aufgabe 120

## Aufgabe

BiboApp wurde um die Razor Page `/Autoren` erweitert.

- Im Layout wurde ein Link zur Page `Autoren` hinzugefügt.
- Die Klasse `Autor` mit den Properties `Id` und `Name` wurde erstellt.
- Der DbContext enthält `DbSet<Autor> Autoren`.
- Die SQLite-Datenbank `bibo.db` enthält die Tabelle `Autoren` mit acht Autoren.
- Die Page `/Autoren` zeigt alle Autoren aus der Datenbank in einer ungeordneten Liste `<ul>` an.

## Ergebnis

Die Seite `http://localhost:5173/Autoren` zeigt acht Autoren an. Der Link `Autoren` ist im oberen Menü von BiboApp erreichbar.