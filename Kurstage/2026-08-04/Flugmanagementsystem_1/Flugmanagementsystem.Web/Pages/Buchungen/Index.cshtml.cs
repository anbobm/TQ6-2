using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Buchungen;

/// <summary>
/// Stellt die Seite mit allen Buchungen bereit.
/// </summary>
public class IndexModel : PageModel
{
    private readonly BookingService _bookingService;
    private readonly FlightService _flightService;

    /// <summary>
    /// Ruft die für die Seite geladenen Buchungen ab.
    /// </summary>
    public IReadOnlyList<Buchung> Buchungen { get; private set; } =
        Array.Empty<Buchung>();

    /// <summary>
    /// Initialisiert die Buchungsübersichtsseite.
    /// </summary>
    /// <param name="bookingService">Der Dienst für Buchungsdaten.</param>
    /// <param name="flightService">Der Dienst für Flugdaten.</param>
    public IndexModel(
        BookingService bookingService,
        FlightService flightService)
    {
        _bookingService = bookingService;
        _flightService = flightService;
    }

    /// <summary>
    /// Lädt alle Buchungen für die Übersicht.
    /// </summary>
    public void OnGet()
    {
        Buchungen = _bookingService.GetAlleBuchungen();
    }

    /// <summary>
    /// Gibt den Kunden einer Buchung zurück.
    /// </summary>
    /// <param name="kundeId">Die Kennung des Kunden.</param>
    /// <returns>Der Kunde oder <see langword="null"/>.</returns>
    public Kunde? GetKunde(int kundeId)
    {
        return _bookingService.GetKundeById(kundeId);
    }

    /// <summary>
    /// Gibt den Flug einer Buchung zurück.
    /// </summary>
    /// <param name="flugId">Die Kennung des Fluges.</param>
    /// <returns>Der Flug oder <see langword="null"/>.</returns>
    public Flug? GetFlug(int flugId)
    {
        return _flightService.GetFlugById(flugId);
    }

    /// <summary>
    /// Storniert die ausgewählte Buchung.
    /// </summary>
    /// <param name="id">Die Kennung der Buchung.</param>
    /// <returns>
    /// Eine Fehlerseite, wenn die Buchung nicht storniert werden kann,
    /// oder eine Weiterleitung zur Buchungsübersicht.
    /// </returns>
    public IActionResult OnPostStornieren(int id)
    {
        if (!_bookingService.StorniereBuchung(id))
        {
            return NotFound();
        }

        return RedirectToPage();
    }

    /// <summary>
    /// Führt den Online-Check-in für die ausgewählte Buchung durch.
    /// </summary>
    /// <param name="id">Die Kennung der Buchung.</param>
    /// <returns>Eine Weiterleitung zur Buchungsübersicht.</returns>
    public IActionResult OnPostCheckIn(int id)
    {
        if (!_bookingService.CheckInBuchung(id))
        {
            TempData["Fehlermeldung"] =
                "Online Check-in ist nur zwischen 24 und 1 Stunde vor Abflug möglich.";
        }

        return RedirectToPage();
    }
}