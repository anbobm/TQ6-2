# Aufgabe 113

Lege ein neues `Razor Pages` Projekt an. Führe dazu in einem Ordner, der einen Projektnamen deiner Wahl trägt, folgenden Befehl aus: `dotnet new razor`

Sollte sich dein Projektordner innerhalb einer Projektmappe (Solution) befinden, füge das Projekt dieser hinzu, indem du im Ordner, der die `.slnx`-Datei enthält folgenden Befehl ausführst: `dotnet solution add <PROJEKTPFAD>`

Bearbeite nun die Index-Page `Page/Index.cshtml`, indem du den vorhandenen HTML-Code durch deinen eigenen ersetzt. Die Direktiven im oberen Teil kannst du ignorieren, vor allem aber darfst du `@page` nicht löschen.

Schreibe nun Razor-Code, der folgendes auf der Index-Page anzeigt:

* das aktuelle Jahr (`DateTime.Now` benutzen mit ToString() oder eine geeignete Property finden)
* die Summe `34 + 35`
* die Summe der Zahlen von 1 bis 100
* eine `<ul>` (unordered list), erzeugt aus dem Array `string[] array = ["dies", "das", "ananas"]`