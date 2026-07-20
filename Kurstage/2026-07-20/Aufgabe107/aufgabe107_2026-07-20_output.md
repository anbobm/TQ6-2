## Aufgabe 107 - Testergebnisse

Schreibe eine Klasse `Lager`. Dabei wurde das TDD-Prinzip angewendet: zuerst wurde ein Unit-Test geschrieben, danach wurde die Klasse implementiert.

Die Klasse `Lager` arbeitet mit einem `IInventar`. Im Unit-Test wird kein echtes Inventar und keine Datenbank benutzt, sondern ein Mock-Objekt aus dem Moq-Paket.

### Getesteter Fall

- `Verkaufen()` gibt `true` zurück, wenn genügend Artikel vorhanden sind.
- Der Bestand wird nach dem Verkauf korrekt reduziert.
- `UpdateBestand()` wird mit dem neuen Bestand aufgerufen.

### Test

```powershell
dotnet test Kurstage/2026-07-20/Aufgabe107/Aufgabe107.csproj