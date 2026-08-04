# Aufgabe 113

## Aufgabe

Ein neues ASP.NET-Core-Projekt mit Razor Pages erstellen:

```powershell
dotnet new razor
```

Das Projekt zur Solution hinzufügen:

```powershell
dotnet solution add <PROJEKTPFAD>
```

Die Datei `Pages/Index.cshtml` bearbeiten und Folgendes ausgeben:

- das aktuelle Jahr;
- die Summe von `34 + 35`;
- die Summe der Zahlen von 1 bis 100;
- die Elemente des Arrays `["dies", "das", "ananas"]` als ungeordnete Liste.

## Ergebnis

Die Razor Page zeigt:

- das aktuelle Jahr mit `DateTime.Now.Year`;
- das Ergebnis `69`;
- die Summe `5050`;
- eine HTML-Liste mit `dies`, `das` und `ananas`.

Das Projekt wurde erfolgreich erstellt, kompiliert und im Browser getestet.