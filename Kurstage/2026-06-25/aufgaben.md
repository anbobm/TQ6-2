# Aufgabe 1

Schreibe eine Klasse `Buch` mit den Attributen `Titel` und `Author`.

Man soll von dieser Klasse Objekte unter der Angabe des Titels erzeugen können (dann soll der Autor automatisch `"Unbekannt"` sein) oder unter der Angabe des Titels *und* des Autors.

# Aufgabe 2

Füge in einer neuen Datei folgenden Code deinem Projekt hinzu:

```csharp
public class Tier
{
    public string Name { get; }

    public Tier(string name)
    {
        Name = name;
    }

    public void SagHallo()
    {
        Console.WriteLine($"Hallo, ich bin {Name}!");
    }
}

public class Hund : Tier
{
    public string Rasse { get; set; }

    public Hund(string rasse)
    {
        Rasse = rasse;
    }
}
```

Sieh dir die Fehlermeldung an und **versuche das Problem nachzuvollziehen**.

Wenn ein Objekt der Klasse `Hund` erzeugt wird, muss auch die Basisklasse `Tier` initialisiert werden (denn ein `Hund` ist ein `Tier` laut unserer Vererbungshierarchie.)

Das passiert normalerweise automatisch, indem der parameterlose Konstruktor der Basisklasse aufgerufen wird. Die Basisklasse `Tier` hat aber keinen parameterlosen Konstruktor, sie hat nur `Tier(string name)`.

Man könnte das Problem nun beheben, indem man einen parameterlosen Konstruktor `Tier()` hinzufügt. **Warum ist das keine gute Idee?**

Besser: der Konstruktor der abgeleiteten Klasse ruft einen konkreten Konstruktor (*mit* Parametern) der Basisklasse auf. Das funktioniert mit dem `base` Keyword:

```csharp
class Basisklasse
{
    private string foo;

    public Basisklasse(string foo)
    {
        this.foo = foo;
    }
}

class AbgeleiteteKlasse : Basisklasse
{
    private string bar;

    public AbgeleiteteKlasse(string foo, int bar) : base(foo)
    {
        this.bar = bar;
    }
}
```

**Passe die Klasse `Hund` entsprechend an.**