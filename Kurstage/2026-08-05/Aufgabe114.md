# Aufgabe 114

Nimm dir die `IQueryCollection`, die sich in der `Request.Query`-Property befindet, und durchlaufe sie in einer Schleife. Die Elemente dieser Collection sind vom Typ `KeyValuePair`.

Gib jedes Schlüssel-Wert-Paar in einer `<ul>` aus.

*Hinweis:* Die Collection enthält natürlich nur dann etwas, wenn der Query-String nicht leer ist. Ruf deine Page also mit einem Query-String deiner Wahl auf, z.B. `?foo=bar&bla=blub`, oder lass den Browser einen Query-String erzeugen, indem du ein Formular abschickst.