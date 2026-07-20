# Aufgabe 107

Schreibe eine Klasse `Lager`. Wende dabei das TDD (test driven development) Prinzip an und schreibe zuerst Unit-Tests.

```csharp
public class Lager
{
    public Lager(IInventar inventar)
    {
        throw new NotImplementedException();
    }

    public bool Verkaufen(int id, int anzahl)
    {
        throw new NotImplementedException();
    }

    public bool Nachbestellen(int id, int anzahl)
    {
        throw new NotImplementedException();
    }
}
```

## Verkaufen()

Prüft ob genug Artikel mit der ID `id` im Bestand vorhanden sind. Falls ja, werden die Artikel verkauft und der Bestand entsprechend reduziert und die Methode gibt `true` zurück. Falls nicht wird nichts verändert und die Methode gibt `false` zurück.

## Nachbestellen()

Erhöht den Bestand im Inventar um die `anzahl` und gibt `true`zurück, allerdings nur, wenn dabei die Kapazität nicht überschritten wird. Wenn die Kapazität überschritten würde, soll nichts getan werden und `false` zurückgegeben werden.

## IInventar

Zur Erfüllung der Funktionalität bekommt die Klasse `Lager` im Konstruktor ein Objekt übergeben, welches das `IIventar`-Interface implementiert:

```csharp
public interface IInventar
{
    int GetBestand(int id);

    int GetKapazität(int id);

    void UpdateBestand(int id, int anzahl);
}
```

Eine Klasse, die dieses Interface implementiert könnte vielleicht so aussehen:

```csharp
public class Inventar : IInventar
{
    int GetBestand(int id)
    {
        // Datenbankabfrage an SQL-DB
    }

    int GetKapazität(int id)
    {
        // Datenbankabfrage an SQL-DB
    }

    void UpdateBestand(int id, int anzahl)
    {
        // Datenbankabfrage an SQL-DB
    }
}
```

In einem Unit-Test wollen wir jedoch nur eine kleine Einheit testen. Eine Kommunikation mit einer Datenbank ist nicht erwünscht.

Wenn wir Unit-Tests für die `Lager`-Klasse schreiben, werden wir folglich das `IIventar`-Objekt durch ein `Mock` ersetzen, welches das Verhalten imitiert.