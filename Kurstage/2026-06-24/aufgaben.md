# Aufgabe 1

Erstelle eine Klasse `Hotelzimmer` mit den öffentlichen Attributen `string Zimmernummer`, `int AnzahlGaeste`, `int MaxGaeste`, `bool Belegt`, `string GastName`.

Die Zimmernummer wird dem Konstruktor übergeben, die anderen Attribute können auf ihren default-Werten belassen werden.

Erzeuge von dieser Klasse Objekte und setze dann die Attribute auf beliebige Werte.

Wie du sehen kannst, ist es möglich durch den direkten Zugriff auf die Attribute das Objekt in einen unsinnigen Zustand zu bringen, z.B. `MaxGaeste` ist 3 aber `AnzahlGaeste` ist 5 (es sind also 2 Gäste mehr im Zimmer als reinpassen), oder `AnzahlGaeste` ist negativ, oder `AnzahlGaeste` ist größer null aber `Belegt` ist gleichzeitig `false`, etc.

# Aufgabe 2

Das Problem in Aufgabe 1 lässt sich durch Kapselung beheben. Mache die Attribute privat, und schreibe (öffentliche) Methoden, die den Zustand des Objekts von außen in einer kontrollierten und inhaltlich konsistenten Weise verändern.