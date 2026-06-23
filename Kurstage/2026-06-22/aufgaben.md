# Aufgabe 1

Schreibe eine Methode `Durchschnitt(..)`, die eine Liste `List<int>` erhält und daraus den Durchschnitt berechnet.

Für welche Argumente wird in dieser Methode eine Exception geworfen?

Fange die Exception in der Aufrufenden Methode ab und behandle sie mit einer Fehlermeldung.

# Aufgabe 2

Schreibe ein Programm welches den Benutzer nach zwei Zahlen fragt und anschließend diese beiden Zahlen dividiert und das Ergebnis anzeigt.

Welche Arten von Exceptions können hier auftreten? Fange sie ab und behandle sie mit einer Fehlermeldung für den Benutzer.

Lässt sich das Problem auch ohne Exceptions beheben?

# Aufgabe 3

Betrachte folgenden Code:

```csharp
var studenten = new Dictionary<string, Dictionary<string, int>>
{
    { "Alice", new Dictionary<string, int> { { "Mathematik", 95 }, { "Englisch", 88 }, { "Geschichte", 90 } } },
    { "Bob", new Dictionary<string, int> { { "Mathematik", 75 }, { "Englisch", 81 }, { "Geschichte", 78 } } },
    { "Charlie", new Dictionary<string, int> { { "Mathematik", 88 }, { "Englisch", 91 }, { "Geschichte", 85 } } },
    { "Diana", new Dictionary<string, int> { { "Mathematik", 93 }, { "Englisch", 89 }, { "Geschichte", 94 } } }
};

Console.WriteLine("Folgende Studenten sind gespeichert:");
foreach (var student in studenten)
{
    Console.WriteLine(student.Key);
}

Console.Write("\nGib einen Namen ein für eine Detailansicht: ");
var eingabe = Console.ReadLine()!;

foreach (var fach in studenten[eingabe])
{
    Console.WriteLine($"{fach.Key}: {fach.Value}");
}
```

An welcher Stelle kann eine Exception auftreten?
Schreibe den Code so, dass die Exception aufgefangen und mit einer Fehlermeldung behandelt wird.
Zeige auch wie man verhindert dass die Exception überhaupt auftritt.