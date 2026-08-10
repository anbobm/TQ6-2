using Flugmanagementsystem.Web.Models;

namespace Flugmanagementsystem.Web.Services;

public class FlightService
{
    private readonly List<Flug> _fluege =
    [
        new Flug
        {
            FlugId = 1,
            Flugnummer = "AN210",
            Abflugort = "Frankfurt (FRA)",
            Zielort = "Barcelona (BCN)",
            Abflugzeit = DateTime.Today.AddDays(7).AddHours(8).AddMinutes(15),
            Ankunftszeit = DateTime.Today.AddDays(7).AddHours(10).AddMinutes(30),
            AnzahlSitzplaetze = 180,
            MaximaleZuladung = 5000m,
            Preis = 129.00m,
            Status = "Geplant"
        },
        new Flug
        {
            FlugId = 2,
            Flugnummer = "AN315",
            Abflugort = "München (MUC)",
            Zielort = "Paris (CDG)",
            Abflugzeit = DateTime.Today.AddDays(8).AddHours(11).AddMinutes(20),
            Ankunftszeit = DateTime.Today.AddDays(8).AddHours(13),
            AnzahlSitzplaetze = 160,
            MaximaleZuladung = 4200m,
            Preis = 149.00m,
            Status = "Geplant"
        },
        new Flug
        {
            FlugId = 3,
            Flugnummer = "AN422",
            Abflugort = "Berlin (BER)",
            Zielort = "Rom (FCO)",
            Abflugzeit = DateTime.Today.AddDays(10).AddHours(9),
            Ankunftszeit = DateTime.Today.AddDays(10).AddHours(11).AddMinutes(10),
            AnzahlSitzplaetze = 170,
            MaximaleZuladung = 4600m,
            Preis = 199.00m,
            Status = "Geplant"
        },
        new Flug
        {
            FlugId = 4,
            Flugnummer = "AN518",
            Abflugort = "Hamburg (HAM)",
            Zielort = "Kopenhagen (CPH)",
            Abflugzeit = DateTime.Today.AddDays(14).AddHours(6).AddMinutes(45),
            Ankunftszeit = DateTime.Today.AddDays(14).AddHours(8).AddMinutes(10),
            AnzahlSitzplaetze = 150,
            MaximaleZuladung = 4000m,
            Preis = 179.00m,
            Status = "Geplant"
        }
    ];

    public IReadOnlyList<Flug> GetAlleFluege() => _fluege;

    public Flug? GetFlugById(int flugId) =>
        _fluege.FirstOrDefault(flug => flug.FlugId == flugId);
}