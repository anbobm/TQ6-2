# Aufgabe 117

Schreibe eine Page, die dem Benutzer eine Liste mit allen* Artikeln anzeigt, z.B. so (Id: Artikelname):

* 1: Klimaanlage
* 2: Eismaschine
* 3: Kaffeemaschine
* 4: Waschmaschine

Außerdem, soll es ein Formular geben, wo der Benutzer eine Artikel-Id eingeben kann. Nach dem Absenden wird zusätzlich zur Artikelliste eine Detailansicht des entsprechenden Artikels angezeigt, z.B.:

### Klimaanlage

Preis: **1500 €** inkl. MwSt

Klimaanlage, die Luft kalt macht

\* Die Artikelliste würden wir normalerweise aus einer Datenbank holen. Hier erstellen wir uns der Einfachheit halber einfach ein statisches Array aus Objekten der `Artikel`-Klasse.

## `Artikel`-Klasse

```csharp
public class Artikel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Beschreibung { get; set; }
    public decimal Preis { get; set; }
}
```

## Artikelliste

```csharp
public Artikel[] ArtikelListe { get; } =
    [
        new Artikel {
            Id = 1,
            Name = "Klimaanlage",
            Beschreibung = "Klimaanlage, die Luft kalt macht",
            Preis = 1500
        },
        new Artikel {
            Id = 2,
            Name = "Eismaschine",
            Beschreibung = "Hmm, lecker!",
            Preis = 39.95m
        },
        new Artikel {
            Id = 3,
            Name = "Kaffeemaschine",
            Beschreibung = "Hmm, lecker!",
            Preis = 195.95m
        },
        new Artikel {
            Id = 4,
            Name = "Waschmaschine",
            Beschreibung = "Dreht schön",
            Preis = 499.95m
        }
    ];
```