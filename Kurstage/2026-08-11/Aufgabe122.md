# Aufgabe 122

## Überlegung

Zurzeit wird der Autor eines Buches als Text in der Spalte `Autor` gespeichert.

Später soll ein Buch nicht mehr den Namen des Autors als Text speichern, sondern eine Referenz auf einen Datensatz aus der Tabelle `Autoren`. Dafür würde die Tabelle `Bücher` eine Spalte `AutorId` erhalten.

Beim Anlegen eines Buches soll der Benutzer den Autor nicht mehr selbst als Text eingeben. Stattdessen soll die Seite `/BuchHinzufügen` ein Dropdown-Menü mit allen vorhandenen Autoren anzeigen.

Der Benutzer sieht im Dropdown die Namen der Autoren, zum Beispiel `Franz Kafka`. Die Webseite speichert aber die zugehörige Id, zum Beispiel `AutorId = 2`.

## Vorteil

So werden Tippfehler und doppelte unterschiedliche Schreibweisen eines Autors verhindert. Jedes Buch wird eindeutig mit einem vorhandenen Datensatz aus der Tabelle `Autoren` verbunden.