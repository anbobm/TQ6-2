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

Es gibt aber noch eine andere Option: den Konstruktor `private` machen. Jetzt kann man `new Person(...)` außerhalb der Klasse selbst nicht mehr aufrufen. Wie kommt man nun an ein Objekt der Klasse? So: schreibe eine (`public`) Methode `Create(string name)`, die den übergebenen Namen validiert und falls gültig ein `Person`-Objekt zurückgibt, ansonsten `null`.