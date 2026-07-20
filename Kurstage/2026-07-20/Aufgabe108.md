# Aufgabe 108

Die folgende Klasse soll mit TDD implementiert werden.

```csharp
public class JackenBerater
{
    public bool JackeAnziehen(int grenzwert, IWetterApi wetter)
    {
        throw new NotImplementedException();
    }
}
```

`JackeAnziehen()` gibt `true` zurück, wenn die Temperatur kleiner als der Grenzwert (z.B. 20 °C) ist, ansonsten `false`.

Wie die aktuelle Temperatur ist, erfährt die Methode durch `IWetterApi`'s `TemperaturCelsius()`-Methode.

```csharp
public interface IWetterApi
{
    int TemperaturCelsius();
}
```

Eine (angedeutete) konkrete Implementierung dieses Interfaces könnte so aussehen:

```csharp
public class WetterOnline : IWetterApi
{
    public int TemperaturCelsius()
    {
        // HTTP-Request zu WetterOnline API
    }
}
```

Zum Testen wäre eine Instanz von `WetterOnline` ungeeignet: zum einen würden wir diese Klasse dann mittesten, zum anderen müssten wir warten, bis sich draußen die Temperatur ändert um alle Testfälle zu erfassen.

Wir nehmen also stattdessen ein gemocktes Objekt, welches das `IWetterApi`-Interface nachahmt.