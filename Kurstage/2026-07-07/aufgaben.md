# Aufgabe 1

Schreibe ein Programm, welches vom Benutzer den Namen einliest und anschließend daraus ein Objekt der Klasse `Person` erzeugt.

Das Objekt soll nur erzeugt werden, wenn der eingegebene Name gültig ist.

Die Validierung soll in der Klasse `Person` passieren.

Der Konstruktor soll `private` sein.

Eine öffentliche statische Methode `Create(string name)` prüft den Namen:

- wenn der Name gültig ist, wird ein `Person`-Objekt zurückgegeben
- wenn der Name ungültig ist, wird `null` zurückgegeben