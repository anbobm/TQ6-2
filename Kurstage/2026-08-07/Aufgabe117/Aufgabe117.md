# Aufgabe 117

## Aufgabe

Schreibe eine Page, die dem Benutzer eine Liste mit allen Artikeln
anzeigt.

Beispiel:

- 1: Klimaanlage
- 2: Eismaschine
- 3: Kaffeemaschine
- 4: Waschmaschine

Außerdem soll es ein Formular geben, in dem der Benutzer eine
Artikel-Id eingeben kann.

Nach dem Absenden wird zusätzlich zur Artikelliste eine Detailansicht
des entsprechenden Artikels angezeigt.

## Artikel-Klasse

```csharp
public class Artikel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Beschreibung { get; set; }
    public decimal Preis { get; set; }
}


## Hinweis
Die Artikelliste wird normalerweise aus einer Datenbank geladen.
Für diese Aufgabe wird stattdessen ein statisches Array aus
Artikel-Objekten verwendet.

## Erwartetes Ergebnis
Die Seite zeigt:
eine Liste aller Artikel;
ein Formular für die Artikel-Id;
die Details des ausgewählten Artikels;
Name, Beschreibung und Preis des Artikels.