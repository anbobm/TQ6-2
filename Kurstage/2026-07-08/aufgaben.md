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