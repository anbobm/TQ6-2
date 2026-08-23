# Flugmanagementsystem

Ein Flugmanagementsystem für Mitarbeiter einer Airline und Kunden.

## Funktionen

### Kunden

- Verfügbare Flüge ansehen
- Flugdaten ansehen
- Flüge buchen
- Buchungen ansehen
- Buchungen stornieren
- Online Check-in
- Gepäck hinzufügen

### Mitarbeiter

- Neue Flüge anlegen
- Flüge bearbeiten
- Flüge stornieren
- Flugdaten und Flugstatistik ansehen

## Regeln

- Ein neuer Flug darf nicht in der Vergangenheit liegen.
- Die Ankunftszeit muss nach der Abflugzeit liegen.
- Flugnummern dürfen nicht doppelt sein.
- Ein stornierter Flug kann nicht gebucht werden.
- Eine Buchung kann nur im Status `Bestätigt` eingecheckt werden.
- Online Check-in ist nur zwischen 24 und 1 Stunde vor Abflug möglich.
- Pro Buchung sind maximal zwei Gepäckstücke erlaubt.
- Bis 23 kg ist ein Gepäckstück kostenlos.
- Von mehr als 23 kg bis 32 kg kostet ein Gepäckstück 50 € Zuschlag.
- Gepäck über 32 kg ist nicht erlaubt.

## Datenmodell

```text
Kunde
- KundeId
- Vorname
- Nachname
- Email

Flug
- FlugId
- Flugnummer
- Abflugort
- Zielort
- Abflugzeit
- Ankunftszeit
- AnzahlSitzplaetze
- MaximaleZuladung
- Preis
- Status

Buchung
- BuchungId
- KundeId
- FlugId
- Buchungsdatum
- Status
- IstEingecheckt

Gepaeckstueck
- GepaeckstueckId
- BuchungId
- Gewicht



Kunde 1 ───── * Buchung * ───── 1 Flug
                    |
                    |
                    *
             Gepaeckstueck



Benutzeroberfläche
- Flüge: Kundenbereich mit verfügbaren Flügen.
- Buchungen: Übersicht und Verwaltung von Buchungen.
- Verwaltung: Mitarbeiterbereich zum Anlegen, Bearbeiten und Stornieren von Flügen.
Technik
- ASP.NET Core Razor Pages
- C#
- Entity Framework Core
- SQLite
Die Datenbankdatei liegt in:
DATA/flugmanagement.db