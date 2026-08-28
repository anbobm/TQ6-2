using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Buchungen;

/// <summary>
/// Stellt die Seite zur Verwaltung von Gepäckstücken einer Buchung bereit.
/// </summary>
public class GepaeckModel : PageModel
{
    private readonly BookingService _bookingService;
    private readonly FlightService _flightService;

    /// <summary>
    /// Ruft die ausgewählte Buchung ab.
    /// </summary>
    public Buchung? Buchung { get; private set; }

    /// <summary>
    /// Ruft den zur Buchung gehörenden Flug ab.
    /// </summary>
    public Flug? Flug { get; private set; }

    /// <summary>
    /// Ruft die zur Buchung gehörenden Gepäckstücke ab.
    /// </summary>
    public IReadOnlyList<Gepaeckstueck> Gepaeckstuecke { get; private set; } =
        Array.Empty<Gepaeckstueck>();

    /// <summary>
    /// Ruft eine Fehlermeldung ab oder legt sie fest.
    /// Die Meldung bleibt nach einer Weiterleitung verfügbar.
    /// </summary>
    [TempData]
    public string? Fehlermeldung { get; set; }

    /// <summary>
    /// Initialisiert die Gepäckseite.
    /// </summary>
    /// <param name="bookingService">Der Dienst für Buchungsdaten.</param>
    /// <param name="flightService">Der Dienst für Flugdaten.</param>
    public GepaeckModel(
        BookingService bookingService,
        FlightService flightService)
    {
        _bookingService = bookingService;
        _flightService = flightService;
    }

    /// <summary>
    /// Lädt die Buchung, den zugehörigen Flug und die Gepäckstücke.
    /// </summary>
    /// <param name="buchungId">Die Kennung der Buchung.</param>
    /// <returns>
    /// Die Gepäckseite oder eine Fehlerseite, wenn die Buchung nicht vorhanden ist.
    /// </returns>
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

    /// <summary>
    /// Prüft das Gewicht und fügt der Buchung ein Gepäckstück hinzu.
    /// </summary>
    /// <param name="buchungId">Die Kennung der Buchung.</param>
    /// <param name="gewicht">Das Gewicht des Gepäckstücks in Kilogramm.</param>
    /// <returns>
    /// Eine Fehlerseite, wenn die Buchung nicht vorhanden ist,
    /// oder eine Weiterleitung zur Gepäckseite.
    /// </returns>
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