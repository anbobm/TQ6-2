# Aufgabe 118

## Aufgabe

Erweitere die Page aus Aufgabe 117 so, dass es zu jedem Artikel in der Artikelliste einen Link gibt, der die Detailansicht für diesen aufruft.

Das `href`-Attribut des `<a>`-Tags sieht für den Artikel mit der Id `1` so aus:

```text
/?id=1

<ul>
    <li>1: Klimaanlage - <a href="/?id=1">Detailansicht</a></li>
    <li>2: Eismaschine - <a href="/?id=2">Detailansicht</a></li>
    <li>3: Kaffeemaschine - <a href="/?id=3">Detailansicht</a></li>
    <li>4: Waschmaschine - <a href="/?id=4">Detailansicht</a></li>
</ul>