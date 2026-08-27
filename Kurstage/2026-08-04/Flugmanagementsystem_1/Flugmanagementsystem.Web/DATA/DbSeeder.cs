using Flugmanagementsystem.Web.Models;

namespace Flugmanagementsystem.Web.Data;

/// <summary>
/// Stellt die initialen Testdaten für die GermanyFly-Datenbank bereit.
/// </summary>
public static class DbSeeder
{
    /// <summary>
    /// Fügt der Datenbank Beispiel-Flüge hinzu, wenn noch keine Flüge
    /// gespeichert sind.
    /// </summary>
    /// <param name="db">Der Datenbankkontext der Anwendung.</param>
    public static void Seed(AppDbContext db)
    {
        if (db.Fluege.Any())
        {
            return;
        }

        var heute = DateTime.Today;

        db.Fluege.AddRange(
            new Flug
            {
                Flugnummer = "AN210",
                Abflugort = "Frankfurt (FRA)",
                Zielort = "Barcelona (BCN)",
                Abflugzeit = heute.AddDays(7).AddHours(8).AddMinutes(15),
                Ankunftszeit = heute.AddDays(7).AddHours(10).AddMinutes(30),
                AnzahlSitzplaetze = 180,
                MaximaleZuladung = 5000,
                Preis = 129.00m,
                Status = "Geplant"
            },
            new Flug
            {
                Flugnummer = "AN315",
                Abflugort = "München (MUC)",
                Zielort = "Paris (CDG)",
                Abflugzeit = heute.AddDays(8).AddHours(11).AddMinutes(20),
                Ankunftszeit = heute.AddDays(8).AddHours(13),
                AnzahlSitzplaetze = 160,
                MaximaleZuladung = 4800,
                Preis = 149.00m,
                Status = "Geplant"
            },
            new Flug
            {
                Flugnummer = "AN422",
                Abflugort = "Berlin (BER)",
                Zielort = "Rom (FCO)",
                Abflugzeit = heute.AddDays(10).AddHours(9),
                Ankunftszeit = heute.AddDays(10).AddHours(11).AddMinutes(10),
                AnzahlSitzplaetze = 170,
                MaximaleZuladung = 4600,
                Preis = 199.00m,
                Status = "Geplant"
            },
            new Flug
            {
                Flugnummer = "AN518",
                Abflugort = "Hamburg (HAM)",
                Zielort = "Kopenhagen (CPH)",
                Abflugzeit = heute.AddDays(14).AddHours(6).AddMinutes(45),
                Ankunftszeit = heute.AddDays(14).AddHours(8).AddMinutes(10),
                AnzahlSitzplaetze = 150,
                MaximaleZuladung = 4200,
                Preis = 179.00m,
                Status = "Geplant"
            });

        db.SaveChanges();
    }
}