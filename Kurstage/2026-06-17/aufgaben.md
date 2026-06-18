# Aufgabe 1

Schreibe eine Methode `IndexVon`, die ein `int`-Array und einen Wert (`int`) übergeben bekommt und dann das erste Auftreten dieses Wertes in dem Array findet und dessen Index zurückgibt. Sollte der Wert im Array nicht vorkommen soll die Methode `-1` zurückgeben.

```csharp
static int IndexVon(int[] array, int value)
{
    ...
}

private static void Main(string[] args)
{
    var index = IndexVon([2, 5, -17, 28, -17], -17);
    Console.WriteLine(index); // Ausgabe: 2

    index = IndexVon([2, 5, -17, 28, -17], 3);
    Console.WriteLine(index); // Ausgabe: -1
}
```

# Aufgabe 2

Schreibe eine Methode `IndexVon_Tupel(..)`, die genau funktioniert wie die Methode `IndexVon` aus Aufgabe 1, allerdings soll sie statt nur den Index zurückzugeben ein Tupel aus Index und gesuchtem Wert zurückgeben: `(int Index, int Value)`.

```csharp
private static void Main(string[] args)
{
    var index = IndexVon_Tupel([2, 5, -17, 28], -17);
    Console.WriteLine(index); // Ausgabe: (2, -17)

    index = IndexVon_Tupel([2, 5, -17, 28], 3);
    Console.WriteLine(index); // Ausgabe: (-1, 3)
}
```