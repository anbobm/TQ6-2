# Aufgabe 116

## Aufgabe

Schreibe eine Seite, die den Namen des Benutzers
in einem Formular abfragt und den Benutzer nach dem Absenden
mit seinem Namen begrüßt.

Schreibe die Logik dafür in die `OnGet()`-Methode des PageModels.

Der Parameter der `OnGet()`-Methode muss genauso heißen
wie das `name`-Attribut des zugehörigen Input-Elements.

Der Begrüßungstext wird in einer Property des Models gespeichert
und auf der Razor Page mit `@Model.PropertyName` ausgegeben.

## Erwartetes Ergebnis

Der Benutzer gibt seinen Namen ein.

Nach dem Absenden erscheint eine persönliche Begrüßung
mit dem eingegebenen Namen.