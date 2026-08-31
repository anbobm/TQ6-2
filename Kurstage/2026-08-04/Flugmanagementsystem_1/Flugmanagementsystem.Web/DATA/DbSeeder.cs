using Flugmanagementsystem.Web.Models;

namespace Flugmanagementsystem.Web.Data;

/// <summary>
/// Stellt die Testdaten für die GermanyFly-Datenbank bereit.
/// </summary>
public static class DbSeeder
{
    /// <summary>
    /// Legt fehlende Demo-Flüge beim ersten Anwendungsstart an.
    /// Bereits vorhandene Flüge werden nicht geändert, damit bestehende
    /// Buchungen ihre ursprünglichen Flugdaten behalten.
    /// </summary>
    /// <param name="db">Der Datenbankkontext der Anwendung.</param>
    public static void Seed(AppDbContext db)
    {
        var jetzt = DateTime.Now;

        FuegeDemoFlugHinzuFallsFehlt(
            db,
            "AN210",
            "Frankfurt (FRA)",
            "Barcelona (BCN)",
            jetzt.AddHours(2),
            jetzt.AddHours(4).AddMinutes(15),
            180,
            5000,
            129.00m);

        FuegeDemoFlugHinzuFallsFehlt(
            db,
            "AN315",
            "München (MUC)",
            "Paris (CDG)",
            jetzt.AddDays(1).AddHours(2),
            jetzt.AddDays(1).AddHours(3).AddMinutes(40),
            160,
            4800,
            149.00m);

        FuegeDemoFlugHinzuFallsFehlt(
            db,
            "AN422",
            "Berlin (BER)",
            "Rom (FCO)",
            jetzt.AddDays(3).AddHours(2),
            jetzt.AddDays(3).AddHours(4).AddMinutes(10),
            170,
            4600,
            199.00m);

        FuegeDemoFlugHinzuFallsFehlt(
            db,
            "AN518",
            "Hamburg (HAM)",
            "Kopenhagen (CPH)",
            jetzt.AddDays(7).AddHours(2),
            jetzt.AddDays(7).AddHours(3).AddMinutes(25),
            150,
            4200,
            179.00m);

        db.SaveChanges();
    }

    private static void FuegeDemoFlugHinzuFallsFehlt(
        AppDbContext db,
        string flugnummer,
        string abflugort,
        string zielort,
        DateTime abflugzeit,
        DateTime ankunftszeit,
        int anzahlSitzplaetze,
        decimal maximaleZuladung,
        decimal preis)
    {
        var flug = db.Fluege.SingleOrDefault(f => f.Flugnummer == flugnummer);

        if (flug is not null)
        {
            return;
        }

        db.Fluege.Add(new Flug
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
        });
    }
}
