using Flugmanagementsystem.Web.Data;
using Flugmanagementsystem.Web.Models;

namespace Flugmanagementsystem.Web.Services;

/// <summary>
/// Stellt Funktionen zum Anzeigen, Erstellen, Bearbeiten und Stornieren
/// von Flügen bereit.
/// </summary>
public class FlightService
{
    private readonly AppDbContext _db;

    /// <summary>
    /// Initialisiert eine neue Instanz des <see cref="FlightService"/>.
    /// </summary>
    /// <param name="db">Der Datenbankkontext der Anwendung.</param>
    public FlightService(AppDbContext db)
    {
        _db = db;
    }

    /// <summary>
    /// Gibt alle Flüge nach der Abflugzeit sortiert zurück.
    /// </summary>
    /// <returns>Eine Liste aller gespeicherten Flüge.</returns>
    public IReadOnlyList<Flug> GetAlleFluege()
    {
        return _db.Fluege
            .OrderBy(flug => flug.Abflugzeit)
            .ToList();
    }

    /// <summary>
    /// Sucht einen Flug anhand seiner Kennung.
    /// </summary>
    /// <param name="flugId">Die eindeutige Kennung des Fluges.</param>
    /// <returns>
    /// Den gefundenen Flug oder <see langword="null"/>, wenn kein Flug
    /// mit dieser Kennung vorhanden ist.
    /// </returns>
    public Flug? GetFlugById(int flugId)
    {
        return _db.Fluege.Find(flugId);
    }

    /// <summary>
    /// Prüft die eingegebenen Flugdaten und erstellt einen neuen Flug.
    /// </summary>
    /// <param name="flugnummer">Die eindeutige Flugnummer.</param>
    /// <param name="abflugort">Der Abflugort.</param>
    /// <param name="zielort">Der Zielort.</param>
    /// <param name="abflugzeit">Das Datum und die Uhrzeit des Abflugs.</param>
    /// <param name="ankunftszeit">Das Datum und die Uhrzeit der Ankunft.</param>
    /// <param name="anzahlSitzplaetze">Die Anzahl der Sitzplätze.</param>
    /// <param name="maximaleZuladung">Die maximale Zuladung in Kilogramm.</param>
    /// <param name="preis">Der Preis eines Flugtickets.</param>
    /// <returns>
    /// Den erstellten Flug oder <see langword="null"/>, wenn die Daten
    /// ungültig sind oder die Flugnummer bereits existiert.
    /// </returns>
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

    /// <summary>
    /// Storniert einen vorhandenen aktiven Flug.
    /// </summary>
    /// <param name="flugId">Die eindeutige Kennung des Fluges.</param>
    /// <returns>
    /// <see langword="true"/>, wenn der Flug storniert wurde;
    /// andernfalls <see langword="false"/>.
    /// </returns>
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

    /// <summary>
    /// Ändert den Status eines aktiven Fluges.
    /// </summary>
    /// <param name="flugId">Die eindeutige Kennung des Fluges.</param>
    /// <param name="status">Der neue Status des Fluges.</param>
    /// <returns>
    /// <see langword="true"/>, wenn der Status aktualisiert wurde;
    /// andernfalls <see langword="false"/>.
    /// </returns>
    public bool AktualisiereFlugStatus(int flugId, string status)
    {
        var flug = GetFlugById(flugId);

        if (flug is null ||
            flug.Status == "Storniert" ||
            (status != "Geplant" && status != "Verspätet"))
        {
            return false;
        }

        flug.Status = status;
        _db.SaveChanges();

        return true;
    }

    /// <summary>
    /// Prüft und aktualisiert die Daten eines aktiven Fluges.
    /// </summary>
    /// <param name="flugId">Die eindeutige Kennung des Fluges.</param>
    /// <param name="abflugort">Der neue Abflugort.</param>
    /// <param name="zielort">Der neue Zielort.</param>
    /// <param name="abflugzeit">Die neue Abflugzeit.</param>
    /// <param name="ankunftszeit">Die neue Ankunftszeit.</param>
    /// <param name="anzahlSitzplaetze">Die neue Anzahl der Sitzplätze.</param>
    /// <param name="maximaleZuladung">Die neue maximale Zuladung.</param>
    /// <param name="preis">Der neue Ticketpreis.</param>
    /// <returns>
    /// <see langword="true"/>, wenn der Flug aktualisiert wurde;
    /// andernfalls <see langword="false"/>.
    /// </returns>
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
