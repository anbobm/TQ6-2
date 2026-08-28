using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Fluege;

/// <summary>
/// Stellt die Detailseite eines ausgewählten Fluges bereit.
/// </summary>
public class DetailsModel : PageModel
{
    private readonly FlightService _flightService;
    private readonly BookingService _bookingService;

    /// <summary>
    /// Ruft den angezeigten Flug ab.
    /// </summary>
    public Flug? Flug { get; private set; }

    /// <summary>
    /// Ruft die Anzahl der aktiven Buchungen für den Flug ab.
    /// </summary>
    public int AnzahlAktiverBuchungen { get; private set; }

    /// <summary>
    /// Ruft das Gesamtgewicht des Gepäcks für den Flug in Kilogramm ab.
    /// </summary>
    public decimal GesamtGepaeckgewicht { get; private set; }

    /// <summary>
    /// Initialisiert die Detailseite eines Fluges.
    /// </summary>
    /// <param name="flightService">Der Dienst für Flugdaten.</param>
    /// <param name="bookingService">Der Dienst für Buchungsdaten.</param>
    public DetailsModel(
        FlightService flightService,
        BookingService bookingService)
    {
        _flightService = flightService;
        _bookingService = bookingService;
    }

    /// <summary>
    /// Lädt den Flug und seine statistischen Daten.
    /// </summary>
    /// <param name="id">Die Kennung des Fluges.</param>
    /// <returns>
    /// Die Detailseite oder eine Fehlerseite, wenn der Flug nicht vorhanden ist.
    /// </returns>
    public IActionResult OnGet(int id)
    {
        Flug = _flightService.GetFlugById(id);

        if (Flug is null)
        {
            return NotFound();
        }

        AnzahlAktiverBuchungen =
            _bookingService.GetAnzahlAktiverBuchungenByFlugId(Flug.FlugId);

        GesamtGepaeckgewicht =
            _bookingService.GetGesamtGepaeckgewichtByFlugId(Flug.FlugId);

        return Page();
    }
}