## Hinweis: Dies sind Abwandlungen der Aufgaben zu Python. Da wir dort keine Properties benutzt haben, jetzt aber durchaus welche verwenden wollen, kannst du immer davon ausgehen, dass du eine Property benutzen kannst, wenn "getter"- und "setter"-Methoden gefordert sind. Es muss nur sinnvoll sein und funktionieren.

## Aufgabe 1
Schreibe eine Klasse Produkt mit privaten Attributen für Name, Preis und Lagerbestand. Name und Preis erwartet der Konstruktor als Parameter. Der Lagerbestand soll initial 0 sein.

Sie soll außerdem folgende Methoden haben:

Verkaufen(menge): Eine Stückzahl menge des Produkts wird verkauft (nur positive Stückzahlen zulässig), allerdings nur wenn es der Lagerbestand zulässt.
Nachbestellen(menge): Eine Stückzahl menge des Produkts wird nachbestellt. Nur positive Stückzahlen zulässig.
SetPreis(neuerPreis): Keine negativen Preise zulässig
GetInfo(): gibt String mit allen Infos zum Produkt zurück

## Aufgabe 2
Erstelle eine Klasse Rechteck.

Sie hat private Attribute für Breite und Höhe, die der Konstruktor als Parameter erwartet.

Methoden:
SetBreite(wert): (nur positive Werte erlauben)
SetHoehe(wert): (nur positive Werte erlauben)
Flaeche(): gibt Flächeninhalt zurück
Umfang(): gibt Umfang zurück

## Aufgabe 3
Erstelle eine Klasse Benutzer.

Sie hat private Attribute für Benutzername und Passwort, die der Konstruktor als Parameter erwartet. Außerdem hat sie ein privates Attribut istEingeloggt (Boolean), zu Anfang false.

Methoden:
Login(passwort): Loggt den Benutzer ein (istEingeloggt wird true), wenn das Passwort übereinstimmt
Logout(): Loggt den Benutzer aus (ändert istEingeloggt).
PasswortÄndern(altesPw, neuesPw): ändert das Passwort auf neuesPw, vorausgesetzt altesPw stimmt mit dem hinterlegten Passwort überein und neuesPw ist mindestens 8 Zeichen lang.
Eingeloggt(): Gibt zurück ob der Nutzer eingeloggt ist (Boolean)

## Aufgabe 4
Erstelle eine Klasse Temperatursensor.

Sie hat ein privates Attribut für die aktuelle Temperatur (in Celsius), die zu Anfang auf 0 gesetzt wird.

Methoden:
SetCelsius(wert): Setzt die Temperatur auf den übergebenen Wert.
GetCelsius(): Gibt die Temperatur in Celsius zurück
GetFahrenheit(): Gibt die Temperatur in Fahrenheit zurück
Erhoehen(wert): Erhöht die Temperatur um den übergebenen Wert
Senken(wert): Senkt die Temperatur um den übergebenen Wert.
Hinweis: Die Temperatur darf nie kleiner als -273.15 sein.

## Aufgabe 5
Erstelle eine Klasse Mitarbeiter mit privaten Attributen für den Namen und das Gehalt, die der Konstruktor als Parameter erwartet.

Methoden:
GetGehalt() gibt das Gehalt zurück
GehaltErhoehen(prozent) erhöht das Gehalt um prozent. Nur positive Werte sind zugelassen.
Erstelle nun eine Klasse Manager. Ein Manager ist ein Mitarbeiter, die Klasse Manager soll also von der Klasse Mitarbeiter erben.

Darüber hinaus hat die Klasse Manager ein privates Attribut für den Bonus, welcher als Parameter im Konstruktor erwartet wird.

Methoden:
Die Methode GetGehalt() der Basisklasse wird überschrieben und berücksichtigt jetzt auch den zusätzlichen Bonus des Managers (Gehalt + Bonus).
SetBonus(bonus) setzt den Bonus auf den Wert bonus. Negative Werte sind nicht erlaubt.