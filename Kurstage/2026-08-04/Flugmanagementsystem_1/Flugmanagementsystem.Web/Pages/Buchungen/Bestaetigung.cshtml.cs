using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Buchungen;

/// <summary>
/// Stellt die Bestätigungsseite einer neu erstellten Buchung bereit.
/// </summary>
public class BestaetigungModel : PageModel
{
    private readonly BookingService _bookingService;
    private readonly FlightService _flightService;

    /// <summary>
    /// Ruft die bestätigte Buchung ab.
    /// </summary>
    public Buchung? Buchung { get; private set; }

    /// <summary>
    /// Ruft den Kunden der Buchung ab.
    /// </summary>
    public Kunde? Kunde { get; private set; }

    /// <summary>
    /// Ruft den Flug der Buchung ab.
    /// </summary>
    public Flug? Flug { get; private set; }

    /// <summary>
    /// Initialisiert die Buchungsbestätigungsseite.
    /// </summary>
    /// <param name="bookingService">Der Dienst für Buchungsdaten.</param>
    /// <param name="flightService">Der Dienst für Flugdaten.</param>
    public BestaetigungModel(
        BookingService bookingService,
        FlightService flightService)
    {
        _bookingService = bookingService;
        _flightService = flightService;
    }

    /// <summary>
    /// Lädt die Buchung sowie die zugehörigen Kunden- und Flugdaten.
    /// </summary>
    /// <param name="id">Die Kennung der Buchung.</param>
    /// <returns>
    /// Die Bestätigungsseite oder eine Fehlerseite, wenn die Buchung
    /// nicht vorhanden ist.
    /// </returns>
    public IActionResult OnGet(int id)
    {
        Buchung = _bookingService.GetBuchungById(id);

        if (Buchung is null)
        {
            return NotFound();
        }

        Kunde = _bookingService.GetKundeById(Buchung.KundeId);
        Flug = _flightService.GetFlugById(Buchung.FlugId);

        return Page();
    }
}