using Flugmanagementsystem.Web.Data;
using Flugmanagementsystem.Web.Models;

namespace Flugmanagementsystem.Web.Services;

public class BookingService
{
    private readonly AppDbContext _db;
    private readonly FlightService _flightService;

    public BookingService(
        AppDbContext db,
        FlightService flightService)
    {
        _db = db;
        _flightService = flightService;
    }

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

    public Kunde? GetKundeById(int kundeId)
    {
        return _db.Kunden.Find(kundeId);
    }

    public IReadOnlyList<Buchung> GetAlleBuchungen()
    {
        return _db.Buchungen
            .OrderByDescending(buchung => buchung.Buchungsdatum)
            .ToList();
    }

    public Buchung? GetBuchungById(int buchungId)
    {
        return _db.Buchungen.Find(buchungId);
    }

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

    public IReadOnlyList<Gepaeckstueck> GetGepaeckstueckeByBuchungId(
        int buchungId)
    {
        return _db.Gepaeckstuecke
            .Where(gepaeck => gepaeck.BuchungId == buchungId)
            .ToList();
    }

    public int GetAnzahlAktiverBuchungenByFlugId(int flugId)
    {
        return _db.Buchungen.Count(buchung =>
            buchung.FlugId == flugId &&
            buchung.Status != "Storniert");
    }

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