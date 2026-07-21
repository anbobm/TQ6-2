# Aufgabe 103

Vervollständige die Klasse `ParkingGarage`, allerdings *erst nachdem*  du alle Tests geschrieben hast. Überlege dir  was alles getestet werden muss, welche Fälle es gibt und welche Randfälle es gibt.

```csharp
public class ParkingGarage
{
    public int FreeSpaces { get; }
    
    public ParkingGarage(int capacity)
    {
    }

    public bool Park()
    {
        throw new NotImplementedException();
    }

    public bool Leave()
    {
        throw new NotImplementedException();
    }
}
```

## `Park()`

Wenn noch mindestens ein Parkplatz frei ist:

* wird ein Auto eingeparkt.
* FreeSpaces verringert sich um 1.
* Die Methode liefert true.

Wenn das Parkhaus voll ist:

* passiert nichts.
* FreeSpaces bleibt gleich.
* Die Methode liefert false.

## `Leave()`

Wenn sich mindestens ein Auto im Parkhaus befindet:

* fährt ein Auto heraus.
* FreeSpaces erhöht sich um 1.
* Die Methode liefert true.

Wenn das Parkhaus leer ist:

* passiert nichts.
* FreeSpaces bleibt gleich.
* Die Methode liefert false.