# Aufgabe 100 - Ausgabe

## Start

```powershell
dotnet run --project Kurstage/2026-07-14/Aufgabe100/Aufgabe100.csproj
```

## Ergebnis

```text
1000,00 Euro in bar bezahlt.
900,00 Euro in bar bezahlt.
850,00 Euro in bar bezahlt.
```

## Kurz erklärt

Die Bestellung enthält einen Artikel für 1000,00 Euro.

- `KeinRabatt` berechnet keinen Rabatt: 1000,00 Euro.
- `StudentenRabatt` berechnet 10 Prozent Rabatt: 900,00 Euro.
- `SeniorenRabatt` berechnet 15 Prozent Rabatt: 850,00 Euro.

Damit zeigt der Programmlauf, dass `BestellungBezahlen()` mit verschiedenen `IRabatt`-Implementierungen funktioniert.
