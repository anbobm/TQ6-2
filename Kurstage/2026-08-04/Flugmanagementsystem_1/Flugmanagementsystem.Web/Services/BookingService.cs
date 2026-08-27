using Flugmanagementsystem.Web.Data;
using Flugmanagementsystem.Web.Models;

namespace Flugmanagementsystem.Web.Services;

/// <summary>
/// Verwaltet Buchungen, Gepäckstücke und Online-Check-ins.
/// </summary>
public class BookingService
{
    private readonly AppDbContext _db;
    private readonly FlightService _flightService;

    /// <summary>
    /// Initialisiert den Buchungsdienst.
    /// </summary>
    /// <param name="db">Der Datenbankkontext.</param>
    /// <param name="flightService">Der Dienst für Flugdaten.</param>
    public BookingService(
        AppDbContext db,
        FlightService flightService)
    {
        _db = db;
        _flightService = flightService;
    }

    /// <summary>
    /// Erstellt eine Buchung für einen vorhandenen oder neuen Kunden.
    /// </summary>
    /// <param name="vorname">Der Vorname des Kunden.</param>
    /// <param name="nachname">Der Nachname des Kunden.</param>
    /// <param name="email">Die E-Mail-Adresse des Kunden.</param>
    /// <param name="flugId">Die Kennung des Fluges.</param>
    /// <returns>Die erstellte Buchung.</returns>
    public Buchung CreateBuchung(
        string vorname,
        string nachname,
        string email,
        int flugId)
    {
        var kunde = _db.Kunden.FirstOrDefault(
            kunde => kunde.Email == email);

        if (kunde is null)
        {
            kunde = new Kunde
            {
                Vorname = vorname,
                Nachname = nachname,
                Email = email
            };

            _db.Kunden.Add(kunde);
            _db.SaveChanges();
        }

        var buchung = new Buchung
        {
            KundeId = kunde.KundeId,
            FlugId = flugId,
            Buchungsdatum = DateTime.Now,
            Status = "Bestätigt"
        };

        _db.Buchungen.Add(buchung);
        _db.SaveChanges();

        return buchung;
    }

    /// <summary>
    /// Sucht einen Kunden anhand seiner Kennung.
    /// </summary>
    /// <param name="kundeId">Die Kennung des Kunden.</param>
    /// <returns>Der Kunde oder <see langword="null"/>.</returns>
    public Kunde? GetKundeById(int kundeId)
    {
        return _db.Kunden.Find(kundeId);
    }

    /// <summary>
    /// Gibt alle Buchungen nach Buchungsdatum sortiert zurück.
    /// </summary>
    /// <returns>Eine Liste aller Buchungen.</returns>
    public IReadOnlyList<Buchung> GetAlleBuchungen()
    {
        return _db.Buchungen
            .OrderByDescending(buchung => buchung.Buchungsdatum)
            .ToList();
    }

    /// <summary>
    /// Sucht eine Buchung anhand ihrer Kennung.
    /// </summary>
    /// <param name="buchungId">Die Kennung der Buchung.</param>
    /// <returns>Die Buchung oder <see langword="null"/>.</returns>
    public Buchung? GetBuchungById(int buchungId)
    {
        return _db.Buchungen.Find(buchungId);
    }

    /// <summary>
    /// Storniert eine aktive Buchung.
    /// </summary>
    /// <param name="buchungId">Die Kennung der Buchung.</param>
    /// <returns>
    /// <see langword="true"/> bei erfolgreicher Stornierung,
    /// andernfalls <see langword="false"/>.
    /// </returns>
    public bool StorniereBuchung(int buchungId)
    {
        var buchung = GetBuchungById(buchungId);

        if (buchung is null || buchung.Status == "Storniert")
        {
            return false;
        }

        buchung.Status = "Storniert";
        _db.SaveChanges();

        return true;
    }

    /// <summary>
    /// Führt den Online-Check-in zwischen 24 und 1 Stunde vor Abflug durch.
    /// </summary>
    /// <param name="buchungId">Die Kennung der Buchung.</param>
    /// <returns>
    /// <see langword="true"/> bei erfolgreichem Check-in,
    /// andernfalls <see langword="false"/>.
    /// </returns>
    public bool CheckInBuchung(int buchungId)
    {
        var buchung = GetBuchungById(buchungId);

        if (buchung is null || buchung.Status != "Bestätigt")
        {
            return false;
        }

        var flug = _flightService.GetFlugById(buchung.FlugId);

        if (flug is null || flug.Status == "Storniert")
        {
            return false;
        }

        var zeitBisAbflug = flug.Abflugzeit - DateTime.Now;

        if (zeitBisAbflug > TimeSpan.FromHours(24) ||
            zeitBisAbflug < TimeSpan.FromHours(1))
        {
            return false;
        }

        buchung.IstEingecheckt = true;
        buchung.Status = "Eingecheckt";
        _db.SaveChanges();

        return true;
    }

    /// <summary>
    /// Fügt einer bestätigten Buchung ein Gepäckstück hinzu.
    /// </summary>
    /// <param name="buchungId">Die Kennung der Buchung.</param>
    /// <param name="gewicht">Das Gewicht in Kilogramm.</param>
    /// <returns>
    /// Das Gepäckstück oder <see langword="null"/>, wenn die Bedingungen
    /// nicht erfüllt sind.
    /// </returns>
    public Gepaeckstueck? AddGepaeckstueck(
        int buchungId,
        decimal gewicht)
    {
        var buchung = GetBuchungById(buchungId);

        var anzahlGepaeckstuecke = _db.Gepaeckstuecke.Count(
            gepaeck => gepaeck.BuchungId == buchungId);

        if (buchung is null ||
            buchung.Status != "Bestätigt" ||
            gewicht <= 0 ||
            gewicht > 32m ||
            anzahlGepaeckstuecke >= 2)
        {
            return null;
        }

        var gepaeckstueck = new Gepaeckstueck
        {
            BuchungId = buchungId,
            Gewicht = gewicht
        };

        _db.Gepaeckstuecke.Add(gepaeckstueck);
        _db.SaveChanges();

        return gepaeckstueck;
    }

    /// <summary>
    /// Gibt alle Gepäckstücke einer Buchung zurück.
    /// </summary>
    /// <param name="buchungId">Die Kennung der Buchung.</param>
    /// <returns>Eine Liste der Gepäckstücke.</returns>
    public IReadOnlyList<Gepaeckstueck> GetGepaeckstueckeByBuchungId(
        int buchungId)
    {
        return _db.Gepaeckstuecke
            .Where(gepaeck => gepaeck.BuchungId == buchungId)
            .ToList();
    }

    /// <summary>
    /// Ermittelt die Anzahl der aktiven Buchungen eines Fluges.
    /// </summary>
    /// <param name="flugId">Die Kennung des Fluges.</param>
    /// <returns>Die Anzahl der aktiven Buchungen.</returns>
    public int GetAnzahlAktiverBuchungenByFlugId(int flugId)
    {
        return _db.Buchungen.Count(buchung =>
            buchung.FlugId == flugId &&
            buchung.Status != "Storniert");
    }

    /// <summary>
    /// Berechnet das gesamte Gepäckgewicht eines Fluges.
    /// </summary>
    /// <param name="flugId">Die Kennung des Fluges.</param>
    /// <returns>Das gesamte Gepäckgewicht in Kilogramm.</returns>
    public decimal GetGesamtGepaeckgewichtByFlugId(int flugId)
    {
        var buchungsIds = _db.Buchungen
            .Where(buchung =>
                buchung.FlugId == flugId &&
                buchung.Status != "Storniert")
            .Select(buchung => buchung.BuchungId)
            .ToHashSet();

        return _db.Gepaeckstuecke
            .Where(gepaeck =>
                buchungsIds.Contains(gepaeck.BuchungId))
            .Sum(gepaeck => gepaeck.Gewicht);
    }
}