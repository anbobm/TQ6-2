# Aufgabe 116

Schreibe eine Page, die den Namen des Benutzers in einem Formular abfragt, und nach dem Absenden den Benutzer mit Namen begrüßt.

Schreibe die Logik dafür in die `OnGet()`-Methode des PageModels. Denke daran, dass die Parameter der `OnGet()`-Methode genauso so heißen müssen, wie das `name`-Attribut des zugehörigen Input-Elements des Formulars.

Auf den Begrüßungstext des Models kannst du von der Razor Page aus wieder mittels einer Property `@Model.<deine Property>` zugreifen.