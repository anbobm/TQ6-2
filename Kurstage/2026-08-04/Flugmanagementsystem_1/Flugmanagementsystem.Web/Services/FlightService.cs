using Flugmanagementsystem.Web.Data;
using Flugmanagementsystem.Web.Models;

namespace Flugmanagementsystem.Web.Services;

public class FlightService
{
    private readonly AppDbContext _db;

    public FlightService(AppDbContext db)
    {
        _db = db;
    }

    public IReadOnlyList<Flug> GetAlleFluege()
    {
        return _db.Fluege
            .OrderBy(flug => flug.Abflugzeit)
            .ToList();
    }

    public Flug? GetFlugById(int flugId)
    {
        return _db.Fluege.Find(flugId);
    }

    public Flug? CreateFlug(
        string flugnummer,
        string abflugort,
        string zielort,
        DateTime abflugzeit,
        DateTime ankunftszeit,
        int anzahlSitzplaetze,
        decimal maximaleZuladung,
        decimal preis)
    {
        if (string.IsNullOrWhiteSpace(flugnummer) ||
            string.IsNullOrWhiteSpace(abflugort) ||
            string.IsNullOrWhiteSpace(zielort) ||
            abflugzeit <= DateTime.Now ||
            ankunftszeit <= abflugzeit ||
            anzahlSitzplaetze <= 0 ||
            maximaleZuladung <= 0 ||
            preis <= 0 ||
            _db.Fluege.Any(flug =>
                flug.Flugnummer.ToUpper() == flugnummer.ToUpper()))
        {
            return null;
        }

        var flug = new Flug
        {
            Flugnummer = flugnummer,
            Abflugort = abflugort,
            Zielort = zielort,
            Abflugzeit = abflugzeit,
            Ankunftszeit = ankunftszeit,
            AnzahlSitzplaetze = anzahlSitzplaetze,
            MaximaleZuladung = maximaleZuladung,
            Preis = preis,
            Status = "Geplant"
        };

        _db.Fluege.Add(flug);
        _db.SaveChanges();

        return flug;
    }

    public bool StorniereFlug(int flugId)
    {
        var flug = GetFlugById(flugId);

        if (flug is null || flug.Status == "Storniert")
        {
            return false;
        }

        flug.Status = "Storniert";
        _db.SaveChanges();

        return true;
    }

    public bool BearbeiteFlug(
        int flugId,
        string abflugort,
        string zielort,
        DateTime abflugzeit,
        DateTime ankunftszeit,
        int anzahlSitzplaetze,
        decimal maximaleZuladung,
        decimal preis)
    {
        var flug = GetFlugById(flugId);

        if (flug is null ||
            flug.Status == "Storniert" ||
            string.IsNullOrWhiteSpace(abflugort) ||
            string.IsNullOrWhiteSpace(zielort) ||
            abflugzeit <= DateTime.Now ||
            ankunftszeit <= abflugzeit ||
            anzahlSitzplaetze <= 0 ||
            maximaleZuladung <= 0 ||
            preis <= 0)
        {
            return false;
        }

        flug.Abflugort = abflugort;
        flug.Zielort = zielort;
        flug.Abflugzeit = abflugzeit;
        flug.Ankunftszeit = ankunftszeit;
        flug.AnzahlSitzplaetze = anzahlSitzplaetze;
        flug.MaximaleZuladung = maximaleZuladung;
        flug.Preis = preis;

        _db.SaveChanges();

        return true;
    }
}