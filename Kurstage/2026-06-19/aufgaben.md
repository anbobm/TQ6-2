# Aufgabe 1

Schreibe eine Methode `DurchschnittsnotenAusgeben()`, welche ein Dictionary bekommt das einem Schlüssel (`string` Name)  eine Liste von Noten (`int`) zuordnet und daraus für jeden Eintrag die Durchschnittsnote berechnet und ausgibt.

```csharp
var noten = new Dictionary<string, List<int>>
{
    { "Alice", new List<int> { 95, 88, 92 } },
    { "Bob", new List<int> { 75, 80, 78 } },
    { "Charlie", new List<int> { 91, 93, 89 } }
};

DurchschnittsnotenAusgeben(noten);
// Ausgabe:
// Alice: 92
// Bob: 78
// Charlie: 91
```

# Aufgabe 2

Schreibe eine Methode `DurchschnittsnotenDictionary(..)`, die genau das gleiche tut wie in Aufgabe 1, allerdings die Durchschnittsnoten nicht ausgibt sondern ein Dictionary zurückgibt, bei dem zu jedem Namen die Durchschnittsnote zu finden ist.
Die aufrufende Methode sorgt dann für die Ausgabe wie in Aufgabe 1.

# Aufgabe 3

Schreibe eine Methode `DurchschnittsnotenTupel(..)`, die genau das gleiche tut wie in Aufgabe 1, allerdings die Durchschnittsnoten nicht ausgibt sondern eine Liste von Tupeln (Name, Durchschnittsnote) zurückgibt.
Die aufrufende Methode sorgt dann für die Ausgabe wie in Aufgabe 1.