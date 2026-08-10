# Aufgabe 119

## Projekt anlegen

Lege ein neues Razor Pages Projekt an mit `dotnet new razor`.

Füge das Projekt gegebenenfalls der Projektmappe (Solution) hinzu mit `dotnet solution add <projekt-pfad>`.

## EF Core installieren

Installiere im Projekt das EntityFrameworkCore-Paket für Sqlite mit `dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 10.0.10`.

## DB-Context hinzufügen

Lege eine Klasse `Db` in der Datei `Db.cs` an mit folgendem Inhalt:

```csharp
using Microsoft.EntityFrameworkCore;

public class Db : DbContext
{
    public DbSet<Buch> Bücher { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=bibo.db");
}
```

## Klasse für Entität Buch anlegen

Erstelle eine Klasse `Buch` in `Buch.cs` mit der folgenden Definition:

```csharp
public class Buch
{
    public int Id { get; set; }

    public string Titel { get; set; }

    public string Autor { get; set; }
}
```

## DB-Datei hinzufügen

Wie man im Connection String im obigen Quellcode sehen kann, wird eine Sqlite-Datenbank in der Datei `bibo.db` erwartet. Diese Datei wird direkt im Wurzelverzeichnis der App gesucht (nicht in `bin/Debug/...`).

Lege diese Datei mit Hilfe des [SQLite-Browsers](https://sqlitebrowser.org) an: erstelle eine Tabelle `Bücher` (gleicher Name wie Property in `Db`, somit müssen wir nichts explizit konfigurieren) mit Spalten entsprechend der Properties der `Buch`-Klasse. (`Id` (`INTEGER`) ist Primärschlüssel, `Titel` und `Autor` sind `TEXT`)

Fülle die Datenbank mit deinen eigenen Daten und/oder führe das SQL-Skript aus:

```sql
INSERT INTO Bücher (Titel, Autor) VALUES
    ('Der kleine Prinz','Antoine de Saint-Exupéry'),
    ('Die Verwandlung', 'Franz Kafka'),
    ('Der alte Mann und das Meer', 'Ernest Hemingway'),
    ('Momo', 'Michael Ende'),
    ('Die unendliche Geschichte', 'Michael Ende'),
    ('Faust', 'Johann Wolfgang von Goethe'),
    ('Im Westen nichts Neues', 'Erich Maria Remarque'),
    ('Das Parfum', 'Patrick Süskind'),
    ('Der Process', 'Franz Kafka'),
    ('Effi Briest', 'Theodor Fontane')
    ;
```

## Index-Page ändern

Die Page `/Index` soll so aussehen:

```razor
@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<h1>Alle Bücher:</h1>

@foreach(var buch in Model.Bücher) {
    <p>@buch.Autor - @buch.Titel</p>
}
```

Das `IndexModel` soll so aussehen:

```csharp
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BiboApp.Pages;

public class IndexModel : PageModel
{
    public List<Buch> Bücher { get; set; }

    public void OnGet()
    {
        var db = new Db();

        Bücher = db.Bücher.ToList();
    }
}
```