## Aufgabe 1
Klasse Unternehmen
Attribute
Name
Abteilungen: Liste von Objekten vom Typ Abteilung
Methoden
AbteilungHinzufügen(abteilung)
AbteilungEntfernen(abteilung)
Klasse Abteilung
Attribute
Bezeichnung
Mitarbeiter: Liste von Objekten vom Typ Mitarbeiter
Methoden
MitarbeiterHinzufügen(mitarbeiter)
MitarbeiterEntfernen(mitarbeiter)
Klasse Mitarbeiter
Attribute
Personalnummer
Name


## Aufgabe 2
Ergänze die Klasse Unternehmen um folgende Methoden:
AbteilungFinden(bezeichnung)
AlleMitarbeiterAnzeigen()
MitarbeiterSuchen(personalnummer)


## ufgabe 3
Ergänze die Klasse Unternehmen um eine Methode info(), die alle Informationen zum Unternehmen, den Abteilungen und ihrer Mitarbeiter ausgibt, z.B. so:
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
Ergänze die Klasse Mitarbeiter um ein Attribut Abteilung. Mit diesem soll sichergestellt werden, dass man einen Mitarbeiter nur einer Abteilung zuweisen kann.


## Aufgabe 5
Wir wollen durchsetzen, dass die personalnummer des Mitarbeiters in einem Unternehmen eindeutig ist. Dazu erstellen wir eine MitarbeiterErzeugen() Methode in Unternehmen, der einen Mitarbeiter nur erstellt, wenn es die übergebene personalnummer im Unternehmen nicht gibt.