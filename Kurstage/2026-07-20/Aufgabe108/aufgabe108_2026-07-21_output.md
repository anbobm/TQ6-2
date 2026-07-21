## Aufgabe 108 - Testergebnisse

Die Klasse `JackenBerater` soll mit TDD implementiert werden.

`JackeAnziehen()` gibt `true` zurück, wenn die aktuelle Temperatur kleiner als der Grenzwert ist. Wenn die Temperatur gleich groß oder größer als der Grenzwert ist, wird `false` zurückgegeben.

Die aktuelle Temperatur wird über das Interface `IWetterApi` abgefragt. Im Unit-Test wird kein echter Wetterdienst verwendet, sondern ein Mock-Objekt mit Moq.

### Testfälle

- Temperatur kleiner als Grenzwert → `true`
- Temperatur gleich Grenzwert → `false`
- Temperatur größer als Grenzwert → `false`

### Ergebnis

```powershell
dotnet test Kurstage/2026-07-20/Aufgabe108/Aufgabe108.csproj
```

```text
Сводка теста: всего: 3; сбой: 0; успешно: 3; пропущено: 0; длительность: 1,3 с
Сборка успешно выполнено через 2,8 с
```

### Fazit

Die Methode `JackeAnziehen()` verwendet die Temperatur aus `IWetterApi` und entscheidet korrekt anhand des Grenzwerts.