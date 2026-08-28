using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Buchungen;

/// <summary>
/// Stellt die Seite zum Erstellen einer neuen Buchung bereit.
/// </summary>
public class ErstellenModel : PageModel
{
    private readonly FlightService _flightService;
    private readonly BookingService _bookingService;

    /// <summary>
    /// Ruft die für die Buchung auswählbaren Flüge ab.
    /// </summary>
    public IReadOnlyList<Flug> Fluege { get; private set; } =
        Array.Empty<Flug>();

    /// <summary>
    /// Ruft die Kennung des vorausgewählten Fluges ab.
    /// </summary>
    public int? AusgewaehlteFlugId { get; private set; }

    /// <summary>
    /// Initialisiert die Seite zum Erstellen einer Buchung.
    /// </summary>
    /// <param name="flightService">Der Dienst für Flugdaten.</param>
    /// <param name="bookingService">Der Dienst für Buchungsdaten.</param>
    public ErstellenModel(
        FlightService flightService,
        BookingService bookingService)
    {
        _flightService = flightService;
        _bookingService = bookingService;
    }

    /// <summary>
    /// Lädt alle Flüge und übernimmt bei Bedarf einen vorausgewählten Flug.
    /// </summary>
    /// <param name="flugId">Die optional vorausgewählte Flugkennung.</param>
    public void OnGet(int? flugId)
    {
        Fluege = _flightService.GetAlleFluege();

        if (flugId.HasValue &&
            _flightService.GetFlugById(flugId.Value) is not null)
        {
            AusgewaehlteFlugId = flugId;
        }
    }

    /// <summary>
    /// Erstellt eine Buchung für den ausgewählten aktiven Flug.
    /// </summary>
    /// <param name="vorname">Der Vorname des Kunden.</param>
    /// <param name="nachname">Der Nachname des Kunden.</param>
    /// <param name="email">Die E-Mail-Adresse des Kunden.</param>
    /// <param name="flugId">Die Kennung des ausgewählten Fluges.</param>
    /// <returns>
    /// Eine Fehlerseite, eine Weiterleitung zur Flugdetailseite oder
    /// zur Bestätigungsseite der Buchung.
    /// </returns>
    public IActionResult OnPost(
        string vorname,
        string nachname,
        string email,
        int flugId)
    {
        var flug = _flightService.GetFlugById(flugId);

        if (flug is null)
        {
            return NotFound();
        }

        if (flug.Status == "Storniert")
        {
            return RedirectToPage(
                "/Fluege/Details",
                new { id = flugId });
        }

        var buchung = _bookingService.CreateBuchung(
            vorname,
            nachname,
            email,
            flugId);

        return RedirectToPage(
            "/Buchungen/Bestaetigung",
            new { id = buchung.BuchungId });
    }
}