# Flugmanagementsystem

Webanwendung zur Verwaltung von Flügen einer Airline.  
Kunden können Flüge suchen, buchen und ihre Buchungen verwalten. Mitarbeiter verwalten die angebotenen Flüge.

## Funktionen

### Kundenbereich

- Verfügbare Flüge anzeigen
- Details eines Fluges ansehen
- Einen Flug buchen
- Eigene Buchungen anzeigen
- Buchungen stornieren
- Gepäck hinzufügen
- Online Check-in durchführen

### Mitarbeiterbereich

- Neue Flüge anlegen
- Flüge bearbeiten
- Flüge stornieren
- Flugdaten und Flugstatistik anzeigen

## Geschäftsregeln

- Ein neuer Flug darf nicht in der Vergangenheit liegen.
- Die Ankunftszeit muss nach der Abflugzeit liegen.
- Flugnummern dürfen nicht doppelt vergeben werden.
- Ein stornierter Flug kann nicht gebucht werden.
- Eine Buchung kann nur im Status `Bestätigt` eingecheckt werden.
- Online Check-in ist nur zwischen 24 und 1 Stunde vor Abflug möglich.
- Pro Buchung sind maximal zwei Gepäckstücke erlaubt.
- Bis 23 kg ist ein Gepäckstück kostenlos.
- Von mehr als 23 kg bis 32 kg kostet ein Gepäckstück 50 € Zuschlag.
- Gepäck über 32 kg ist nicht erlaubt.

## Datenmodell

### Kunde

- KundeId
- Vorname
- Nachname
- Email

### Flug

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

### Buchung

- BuchungId
- KundeId
- FlugId
- Buchungsdatum
- Status
- IstEingecheckt

### Gepaeckstueck

- GepaeckstueckId
- BuchungId
- Gewicht

### Beziehungen

- Ein Kunde kann mehrere Buchungen haben.
- Ein Flug kann von mehreren Kunden gebucht werden.
- Eine Buchung verbindet einen Kunden mit einem Flug.
- Zu einer Buchung können maximal zwei Gepäckstücke gehören.

## Benutzeroberfläche

- **Flüge:** Übersicht aller verfügbaren Flüge und Detailansicht.
- **Buchungen:** Buchung erstellen, bestätigen, stornieren, Gepäck hinzufügen und Check-in.
- **Verwaltung:** Mitarbeiterbereich zum Erstellen, Bearbeiten und Stornieren von Flügen.

## Technik

- ASP.NET Core Razor Pages
- C#
- Entity Framework Core
- SQLite
- Bootstrap

Die Datenbankdatei liegt in:

`Flugmanagementsystem.Web/DATA/flugmanagement.db`