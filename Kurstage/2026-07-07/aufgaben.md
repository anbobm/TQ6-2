# Aufgabe 1

Schreibe ein Programm, welches vom Benutzer den Namen einliest und anschließend daraus ein Objekt der Klasse `Person` erzeugt:

```csharp
public class Person
{
    public string Name { get; }

    ...
}
```

Das Objekt soll aber nur erzeugt werden, wenn der eingegebene Name gültig ist (Validierung). Das könnte man nun selbst tun, direkt nachdem man den String vom Nutzer erhalten hat. Wir wollen die Validierung aber der `Person`-Klasse überlassen. Das Ziel: man soll nur ein Objekt erzeugen können, wenn der im Konstruktor übergebene Name nicht `null` und nicht der leere String `""` ist.

Das Problem: `new Person(...)` liefert immer ein Person-Objekt zurück, auch wenn wir keinen gültigen Namen übergeben (es sei denn wir werfen eine *Exception*).

Es gibt aber noch eine andere Option: den Konstruktor `private` machen. Jetzt kann man `new Person(...)` außerhalb der Klasse selbst nicht mehr aufrufen. Wie kommt man nun an ein Objekt der Klasse? So: schreibe eine (`public`) Methode `Create(string name)`, die den übergebenen Namen validiert und falls gültig ein `Person`-Objekt zurückgibt, ansonsten `null`. Diese Methode muss natürlich `static` sein, damit man sie ohne Objekt aufrufen kann.

# Aufgabe 2

Schreibe eine Methode `public static bool IsValid(string value)`, die eine (13-stellige) [ISBN](https://en.wikipedia.org/wiki/ISBN) bekommt und zurückgibt, ob sie ([gemäß der Prüfsummenberechnung](https://en.wikipedia.org/wiki/ISBN#ISBN-13_check_digit_calculation)) gültig ist. (`a + b + c = 0 (mod 10)` bedeutet einfach nur dass `(a + b + c) / 10` den Rest `0` hat. Dafür kannst du einfach wie gehabt den Modulo-Operator `%` von C# benutzen: `x % 10` liefert den Rest wenn man `x` durch `10` dividiert.)

**Hinweis:** Du kannst zunächst davon ausgehen, dass der String normalisiert ist, also "9780306406157" und nicht "9780-3064-06157" oder ähnliches.

Du kannst folgenden Code ausführen, um deine Methode zu testen:

```csharp
Dictionary<string,bool> isbns = new Dictionary<string, bool>
{
    {"9780306406157", true}, // gültig
    {"9783423264303", true}, // gültig
    {"9781784878979", true}, // gültig
    {"97817-84878-979", true}, // gültig aber mit Trennstrichen
    {"9781784878978", false}, // ungültig
    {"97803064061570", false}, // ungültig (zu lang), könnte aber für manche gültig aussehen
    {"9781784871", false} // ungültig (zu kurz), könnte aber für manche gültig aussehen
};

foreach (var kvp in isbns)
{
    var isbn = kvp.Key;
    var valid = kvp.Value;
    var validString = valid ? "gültig" : "ungültig";

    if (IsValid(isbn) == valid)
    {
        Console.WriteLine($"{isbn} erfolgreich als {validString} erkannt!");
    }
    else
    {
        Console.WriteLine($"FEHLER: {isbn} nicht als {validString} erkannt!");
        
    }
}
```

# Aufgabe 3

Füge die geschriebene Methode `IsValid` als statische Methode einer neuen Klasse `Isbn`.

Jedes Objekt der Klasse `Isbn` soll eine konkrete ISBN-13 repräsentieren. Objekte von ungültigen ISBNs soll es nicht geben. Wir setzen das wieder so um, dass wir den Konstruktor `private` machen und Objekte nur über eine `Create(string value)` Methode erzeugen, die nur bei einer gültigen ISBN ein Objekt zurückgibt, ansonsten `null`.