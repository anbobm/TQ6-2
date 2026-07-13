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

## Aufgabe 2
ErgÃ¤nze die Klasse um folgende Methoden:Unternehmen

AbteilungFinden(bezeichnung)

AlleMitarbeiterAnzeigen()

MitarbeiterSuchen(personalnummer)



## Aufgabe 3
ErgÃ¤nze die Klasse um eine Methode , die alle Informationen zum Unternehmen, den Abteilungen und ihrer Mitarbeiter ausgibt, z.B. so:Unternehmeninfo()

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


## Aufgabe 4
ErgÃ¤nze die Klasse um ein Attribut . Mit diesem soll sichergestellt werden, dass man einen Mitarbeiter nur einer Abteilung zuweisen kann.MitarbeiterAbteilung



## Aufgabe 5
Wir wollen durchsetzen, dass die des s in einem eindeutig ist. Dazu erstellen wir eine Methode in , der einen nur erstellt, wenn es die Ã¼bergebene im Unternehmen nicht gibt.personalnummerMitarbeiterUnternehmenMitarbeiterErzeugen()UnternehmenMitarbeiterpersonalnummer## Ausgabe

```text
Print GmbH
Abteilungen: 4

