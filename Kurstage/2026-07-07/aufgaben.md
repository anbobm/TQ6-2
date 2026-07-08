# Aufgabe 1

Schreibe ein Programm, welches vom Benutzer den Namen einliest und anschließend daraus ein Objekt der Klasse `Person` erzeugt.

Das Objekt soll nur erzeugt werden, wenn der eingegebene Name gültig ist.

Die Validierung soll in der Klasse `Person` passieren.

Der Konstruktor soll `private` sein.

Eine öffentliche statische Methode `Create(string name)` prüft den Namen:

- wenn der Name gültig ist, wird ein `Person`-Objekt zurückgegeben
- wenn der Name ungültig ist, wird `null` zurückgegeben






# Aufgabe 2

Schreibe eine Methode `public static bool IsValid(string value)`, die eine 13-stellige ISBN bekommt und zurueckgibt, ob sie gemaess der Pruefsummenberechnung gueltig ist.

Die ISBN-13 wird mit den Faktoren 1 und 3 berechnet:

`x1 + 3x2 + x3 + 3x4 + ... + x13`

Wenn die Summe durch 10 teilbar ist, ist die ISBN gueltig.

Es werden auch folgende Faelle getestet:

- gueltige ISBN
- ungueltige ISBN
- ISBN mit Trennstrichen
- zu lange ISBN
- zu kurze ISBN