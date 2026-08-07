# Aufgabe 114

## Aufgabe

Nimm dir die `IQueryCollection`, die sich in der
`Request.Query`-Property befindet, und durchlaufe sie in einer Schleife.
Die Elemente dieser Collection sind vom Typ `KeyValuePair`.

Gib jedes Schlüssel-Wert-Paar in einer `<ul>` aus.

## Hinweis

Die Collection enthält nur dann Elemente, wenn der Query-String
nicht leer ist.

Beispiel:

```text
?foo=bar&la=blub