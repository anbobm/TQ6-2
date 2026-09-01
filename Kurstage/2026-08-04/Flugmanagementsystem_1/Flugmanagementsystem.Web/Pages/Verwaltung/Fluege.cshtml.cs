using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Verwaltung;

/// <summary>
/// Stellt die Seite zur Verwaltung aller Flüge für Mitarbeiter bereit.
/// </summary>
public class FluegeModel : PageModel
{
    private readonly FlightService _flightService;

    /// <summary>
    /// Ruft die für die Verwaltungsseite geladenen Flüge ab.
    /// </summary>
    public IReadOnlyList<Flug> Fluege { get; private set; } =
        Array.Empty<Flug>();

    /// <summary>
    /// Initialisiert die Verwaltungsseite für Flüge.
    /// </summary>
    /// <param name="flightService">Der Dienst zur Verwaltung von Flügen.</param>
    public FluegeModel(FlightService flightService)
    {
        _flightService = flightService;
    }

    /// <summary>
    /// Lädt alle Flüge für die Verwaltungsseite.
    /// </summary>
    public void OnGet()
    {
        Fluege = _flightService.GetAlleFluege();
    }

    /// <summary>
    /// Storniert den ausgewählten Flug.
    /// </summary>
    /// <param name="id">Die Kennung des zu stornierenden Fluges.</param>
    /// <returns>
    /// Eine Fehlerseite, wenn der Flug nicht storniert werden kann,
    /// oder eine Weiterleitung zur aktuellen Seite.
    /// </returns>
    public IActionResult OnPostStornieren(int id)
    {
        if (!_flightService.StorniereFlug(id))
        {
            return NotFound();
        }

        return RedirectToPage();
    }

    /// <summary>
    /// Ändert den Status eines aktiven Fluges.
    /// </summary>
    /// <param name="id">Die Kennung des Fluges.</param>
    /// <param name="status">Der neue Flugstatus.</param>
    /// <returns>Eine Weiterleitung zur aktualisierten Verwaltungsseite.</returns>
    public IActionResult OnPostStatusAendern(int id, string status)
    {
        if (!_flightService.AktualisiereFlugStatus(id, status))
        {
            TempData["Fehlermeldung"] =
                "Der Flugstatus konnte nicht geändert werden.";
        }

        return RedirectToPage();
    }
}
