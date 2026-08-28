using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Fluege;

/// <summary>
/// Stellt die Seite mit der Liste aller Flüge bereit.
/// </summary>
public class IndexModel : PageModel
{
    private readonly FlightService _flightService;

    /// <summary>
    /// Ruft die für die Seite geladenen Flüge ab.
    /// </summary>
    public IReadOnlyList<Flug> Fluege { get; private set; } =
        Array.Empty<Flug>();

    /// <summary>
    /// Initialisiert die Flugübersichtsseite.
    /// </summary>
    /// <param name="flightService">Der Dienst für Flugdaten.</param>
    public IndexModel(FlightService flightService)
    {
        _flightService = flightService;
    }

    /// <summary>
    /// Lädt alle Flüge für die Übersicht.
    /// </summary>
    public void OnGet()
    {
        Fluege = _flightService.GetAlleFluege();
    }
}