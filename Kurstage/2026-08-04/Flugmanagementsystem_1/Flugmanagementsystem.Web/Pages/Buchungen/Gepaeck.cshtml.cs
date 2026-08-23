using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Buchungen;

public class GepaeckModel : PageModel
{
    private readonly BookingService _bookingService;
    private readonly FlightService _flightService;

    public Buchung? Buchung { get; private set; }
    public Flug? Flug { get; private set; }

    public IReadOnlyList<Gepaeckstueck> Gepaeckstuecke { get; private set; } =
        Array.Empty<Gepaeckstueck>();

    [TempData]
    public string? Fehlermeldung { get; set; }

    public GepaeckModel(
        BookingService bookingService,
        FlightService flightService)
    {
        _bookingService = bookingService;
        _flightService = flightService;
    }

    public IActionResult OnGet(int buchungId)
    {
        Buchung = _bookingService.GetBuchungById(buchungId);

        if (Buchung is null)
        {
            return NotFound();
        }

        Flug = _flightService.GetFlugById(Buchung.FlugId);

        Gepaeckstuecke =
            _bookingService.GetGepaeckstueckeByBuchungId(buchungId);

        return Page();
    }

    public IActionResult OnPost(int buchungId, decimal gewicht)
    {
        var buchung = _bookingService.GetBuchungById(buchungId);

        if (buchung is null)
        {
            return NotFound();
        }

        var anzahlGepaeckstuecke =
            _bookingService.GetGepaeckstueckeByBuchungId(buchungId).Count;

        if (gewicht <= 0)
        {
            Fehlermeldung = "Bitte gib ein gültiges Gewicht ein.";
        }
        else if (gewicht > 32m)
        {
            Fehlermeldung =
                "Ein Gepäckstück darf maximal 32 kg wiegen.";
        }
        else if (anzahlGepaeckstuecke >= 2)
        {
            Fehlermeldung =
                "Zu dieser Buchung sind bereits 2 Gepäckstücke vorhanden.";
        }
        else if (buchung.Status != "Bestätigt")
        {
            Fehlermeldung =
                "Gepäck kann nur zu einer bestätigten Buchung hinzugefügt werden.";
        }
        else
        {
            _bookingService.AddGepaeckstueck(buchungId, gewicht);
        }

        return RedirectToPage(new { buchungId });
    }
}