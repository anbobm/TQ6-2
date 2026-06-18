# Aufgabe 1

Schreibe eine Methode `SucheTelefonnummer`, welche ein Dictionary `telefonbuch` (Schlüssel ist Name, Wert ist Telefonnummer, beides `string`) und einen gesuchten Namen `name` bekommt, und dann die gefundene Telefonnummer zurückgibt. Sollte kein Eintrag für den Namen vorhanden sein, soll `"Nicht gefunden"` zurückgegeben werden.

```csharp
public static string SucheTelefonnummer(Dictionary<string, string> telefonbuch,
    string name)
{
    ...
}

private static void Main(string[] args)
{
    var telefonbuch = new Dictionary<string, string>
    {
        { "Alice", "555-598123"},
        { "Bob",   "555-934242"}
    };
    
    Console.WriteLine(SucheTelefonnummer(telefonbuch, "Bob"));
    //Ausgabe: 555-934242

    Console.WriteLine(SucheTelefonnummer(telefonbuch, "Malory"));
    //Ausgabe: Nicht gefunden
}
```

# Aufgabe 2

Schreibe eine Methode `ZaehleWorte(woerter)`. Diese bekommt eine `List<string> woerter` übergeben und zählt nun, wie häufig jedes Wort, also jeder `string` in dieser Liste, vorkommt. Sie gibt dann ein Dictionary zurück, in dem zu jedem Wort die Häufigkeit zugeordnet ist:

```csharp
private static void Main(string[] args)
{
    List<string> woerter = ["Apfel", "Banane", "Apfel", "Orange", "Banane", "Apfel"];

    Dictionary<string, int> ergebnis = ZaehleWorte(woerter);

    foreach (var eintrag in ergebnis)
    {
        Console.WriteLine($"{eintrag.Key}: {eintrag.Value}");
    }
    // Ausgabe:
    // Apfel: 3
    // Banane: 2
    // Orange: 1
}
```

## Zusatz:

Kannst du die Aufgabe auch lösen ohne ein Dictionary zu verwenden? Z.B. Rückgabewert ist Liste aus Tupeln (Wort, Anzahl): `[("Apfel", 3), ("Banane", 2), ("Orange", 1)]`.