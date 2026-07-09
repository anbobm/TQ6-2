# Aufgabe 1

Schreibe folgende Klassen:

## Medium

Basisklasse für Medien, die in der Bibliothek zur Verfügung stehen

### Properties:

* `Titel` (nur lesbar, wird im Konstruktor gesetzt)
* `IstAusgeliehen` (nur lesbar, wird von Methoden gesetzt)

### Methoden:

* `Ausleihen()`
* `Zurueckgeben()`

## Buch

Erbt von Medium

### Properties:

* `Seitenzahl` (nur lesbar, wird im Konstruktor gesetzt)
* `Autor` (nur lesbar, wird im Konstruktor gesetzt)

## Dvd

Erbt von Medium

### Attribute:

* `Laufzeit` (nur lesbar, wird im Konstruktor gesetzt)
* `Regisseur` (nur lesbar, wird im Konstruktor gesetzt)

## Bibliothek

### Attribute:

* `Medien` (Liste von Medien)

### Properties:

* `AusgelieheneMedien`: Liste von Medien, die ausgeliehen sind


# Aufgabe 2

Erweitere die Klasse `Bibliothek` so, dass man mit `Hinzufuegen(medium)` neue Medien hinzufügen kann.

# Aufgabe 3

Erstelle eine Klasse `Benutzer` mit der (lesbaren) Property `Name`.

Erweitere die Klasse Medium um (lesbare) Property `AusgeliehenVon`, welche den ausleihenden `Benutzer` speichert. Füge entsprechend die Methoden `Ausleihen(benutzer)` und `Zurückgeben()` hinzu.

# Aufgabe 4

Füge der Klasse `Bibliothek` folgende Properties hinzu:

* `AnzahlMedien`: gibt die Anzahl aller Medien zurück
* `AnzahlBuecher`: gibt die Anzahl aller Bücher zurück *
* `AnzahlDvds`: gibt die Anzahl aller Dvds zurück
* `AnzahlAusgeliehen`: gibt die Anzahl der ausgeliehenen Medien zurück
* `AnzahlVerfügbar`: gibt die Anzahl der verfügbaren Medien zurück

\* Um herauszufinden, welcher (Sub-)Typ in einer Variable gespeichert ist, kann man das `is`-Keyword verwenden: `medium is Buch`, oder man verwendet die `GetType()`-Methode, die jedes Objekt besitzt und vergleicht den Rückgabewert mit einem Typ: `medium.GetType() == typeof(Buch)`.

# Aufgabe 5

Zeichne ein UML-Klassendiagramm welches die Klassen aus Aufgaben 1 bis 4 enthält.