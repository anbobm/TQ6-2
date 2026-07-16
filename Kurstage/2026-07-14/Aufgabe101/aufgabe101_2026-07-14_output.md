# Aufgabe 101 - Ausgabe

## Start

```powershell
dotnet run --project Kurstage/2026-07-14/Aufgabe101/Aufgabe101.csproj
```

## Ergebnis

```text
900,00 Euro in bar bezahlt.
13,49 Euro in bar bezahlt.
```

## Kurz erklärt

In Aufgabe 101 wurde die Klasse `Bestellung` erweitert:

- Es gibt jetzt zwei Konstruktoren.
- Der erste Konstruktor erstellt eine leere Bestellung und Artikel können danach hinzugefügt werden.
- Der zweite Konstruktor übernimmt direkt eine vorhandene Artikelliste.
- Beide Konstruktoren bekommen einen `ILogger`.
- Die Klasse `Bestellung` protokolliert das Erzeugen, das Hinzufügen von Artikeln und das Bezahlen.

Im Beispiel wird `FileLogger` aus `2026-07-13/UnternehmenMitLoggerPlus` verwendet. Dadurch entsteht beim Start zusätzlich eine Datei `protokoll.log`.
