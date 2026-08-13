# Aufgabe 121

## Aufgabe

BiboApp wurde um die Razor Pages `/Bücher` und `/BuchHinzufügen` erweitert.

- Die Page `/Bücher` zeigt alle Bücher aus der Datenbank an.
- Über den Link `Buch hinzufügen` ist die Page `/BuchHinzufügen` erreichbar.
- Die Form enthält die Felder `Titel` und `Autor`.
- Beide Felder sind mit `required` als Pflichtfelder markiert.
- Das Formular verwendet `method="post"`.
- Die Methode `OnPost` erstellt ein neues `Buch`-Objekt und speichert es mit `SaveChanges()` in der Datenbank.
- Die Id wird automatisch von SQLite vergeben.

## Ergebnis

Die Seite `http://localhost:5173/Bücher` zeigt elf Bücher an.
Das neue Buch `Die Räuber` von `Friedrich Schiller` wurde über das Formular erfolgreich gespeichert.