## Aufgabe 1

Klasse Unternehmen

Attribute:
- Name
- Abteilungen: Liste von Objekten vom Typ Abteilung

Methoden:
- AbteilungHinzufuegen(abteilung)
- AbteilungEntfernen(abteilung)

Klasse Abteilung

Attribute:
- Bezeichnung
- Mitarbeiter: Liste von Objekten vom Typ Mitarbeiter

Methoden:
- MitarbeiterHinzufuegen(mitarbeiter)
- MitarbeiterEntfernen(mitarbeiter)

Klasse Mitarbeiter

Attribute:
- Personalnummer
- Name

## Ausgabe

```text
Print GmbH
Abteilungen: 4
```

## Aufgabe 2

Ergaenze die Klasse Unternehmen um folgende Methoden:

- AbteilungFinden(bezeichnung)
- AlleMitarbeiterAnzeigen()
- MitarbeiterSuchen(personalnummer)

## Ausgabe

```text
Alle Mitarbeiter:
001: Tunahan
002: Anne
003: Katja
004: Mohamad
005: Sebastian
006: Ihor
007: Ruwen
008: Nataliya
009: Andreas
010: Efkan
Gefundene Abteilung: Vertrieb
Gefundener Mitarbeiter: 008: Nataliya
```

## Aufgabe 3

Ergaenze die Klasse Unternehmen um eine Methode, die alle Informationen zum Unternehmen, den Abteilungen und ihren Mitarbeitern ausgibt, z.B. so: Unternehmeninfo()

```text
Unternehmen X
    Abteilung A
        Mitarbeiter 1
        Mitarbeiter 2
    Abteilung B
        Mitarbeiter 3
    Abteilung C
        Mitarbeiter 4
        Mitarbeiter 5
        Mitarbeiter 6
```

## Aufgabe 4

Ergaenze die Klasse Mitarbeiter um ein Attribut Abteilung. Mit diesem soll sichergestellt werden, dass man einen Mitarbeiter nur einer Abteilung zuweisen kann.

## Aufgabe 5

Wir wollen durchsetzen, dass die Personalnummer des Mitarbeiters in einem Unternehmen eindeutig ist. Dazu erstellen wir eine Methode MitarbeiterErzeugen() in Unternehmen, die einen Mitarbeiter nur erstellt, wenn es die uebergebene Personalnummer im Unternehmen nicht gibt.
