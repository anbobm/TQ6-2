# Aufgabe 121

Füge der `BiboApp` eine `/BuchHinzufügen`-Page hinzu, analog zur `/AutorHinzufügen`-Page.

Diese Page soll über die `/Bücher`-Page mit einem Link erreichbar sein.

Sie soll ein Formular enthalten, welches den Inhalt für alle Attribute der `Buch`-Entität (außer der `Id`, die wird von der Datenbank automatisch zugewiesen) abfragt.

*Hinweis:* Weil dieses Formular beim Absenden den Zustand des Servers ändern soll ist es nicht zielführend `method="get"` zu benutzen. Hier ist `method="post"` die richtige Wahl.
Dadurch muss der Code, der der Datenbank ein neues `Buch`-Objekt hinzufügen in der `OnPost`-Methode des zugehörigen PageModels stehen, nicht wie bisher üblich in der `OnGet`-Methode.