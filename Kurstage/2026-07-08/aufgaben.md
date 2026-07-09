# Aufgabe 1

Schreibe folgende Klassen:

## Medium

Basisklasse fuer Medien, die in der Bibliothek zur Verfuegung stehen.

Properties:
- Titel: nur lesbar, wird im Konstruktor gesetzt
- IstAusgeliehen: nur lesbar, wird von Methoden gesetzt

Methoden:
- Ausleihen()
- Zurueckgeben()

## Buch

Erbt von Medium.

Properties:
- Seitenzahl: nur lesbar, wird im Konstruktor gesetzt
- Autor: nur lesbar, wird im Konstruktor gesetzt

## Dvd

Erbt von Medium.

Properties:
- Laufzeit: nur lesbar, wird im Konstruktor gesetzt
- Regisseur: nur lesbar, wird im Konstruktor gesetzt

## Bibliothek

Attribute:
- Medien: Liste von Medien

Properties:
- AusgelieheneMedien: Liste von Medien, die ausgeliehen sind
## Ausgabe

Ausgeliehene Medien:
Der Hobbit
Inception
Nach Rueckgabe:
Inception

# Aufgabe 2

Erweitere die Klasse `Bibliothek` so, dass man mit `Hinzufuegen(medium)` neue Medien hinzufuegen kann.

## Ausgabe

text
Medien in der Bibliothek:
Das Parfuem
Harry Potter der Stein der Weisen
Inception



# Aufgabe 3

Erstelle eine Klasse `Benutzer` mit der lesbaren Property `Name`.

Erweitere die Klasse `Medium` um die lesbare Property `AusgeliehenVon`, welche den ausleihenden `Benutzer` speichert.

Fuege entsprechend die Methoden `Ausleihen(benutzer)` und `Zurueckgeben()` hinzu.

## Ausgabe 3
PS C:\Users\Nataliya\Desktop\TQ6-2_Nataliya\Beispiele> dotnet run
Das Parfuem: ausgeliehen von Nataliya
Harry Potter der Stein der Weisen: nicht ausgeliehen
Inception: ausgeliehen von Max
PS C:\Users\Nataliya\Desktop\TQ6-2_Nataliya\Beispiele>



## Aufgabe 4
Füge der Klasse folgende Properties hinzu:Bibliothek

AnzahlMedien: gibt die Anzahl aller Medien zurück
AnzahlBuecher: gibt die Anzahl aller Bücher zurück *
AnzahlDvds: gibt die Anzahl aller Dvds zurück
AnzahlAusgeliehen: gibt die Anzahl der ausgeliehenen Medien zurück
AnzahlVerfügbar: gibt die Anzahl der verfügbaren Medien zurück
* Um herauszufinden, welcher (Sub-)Typ in einer Variable gespeichert ist, kann man das -Keyword verwenden: , oder man verwendet die -Methode, die jedes Objekt besitzt und vergleicht den Rückgabewert mit einem Typ: .ismedium is BuchGetType()medium.GetType() == typeof(Buch)

## Aufgabe 5
Zeichne ein UML-Klassendiagramm welches die Klassen aus Aufgaben 1 bis 4 enthält.

