# Aufgabe 115

## Aufgabe

Schreibe eine Seite mit einem Formular, in dem der Benutzer
sein Geburtsdatum einträgt.

Nach dem Absenden wird der Benutzer zum Geburtstag gratuliert,
falls heute sein Geburtstag ist.

## Werkzeugkiste

- `DateTime.Now`
- `Request.Query["..."]`
- Prüfung und Verarbeitung der Benutzereingabe

## Erwartetes Ergebnis

Die Seite enthält ein Formular für das Geburtsdatum.

Wenn Tag und Monat des eingegebenen Geburtsdatums mit dem heutigen
Tag und Monat übereinstimmen, erscheint eine Geburtstagsgratulation.

Andernfalls erscheint eine passende Information.