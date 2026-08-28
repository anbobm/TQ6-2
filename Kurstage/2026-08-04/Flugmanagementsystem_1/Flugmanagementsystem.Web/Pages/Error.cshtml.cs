using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages;

/// <summary>
/// Stellt die Fehlerseite der GermanyFly-Anwendung bereit.
/// </summary>
[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class ErrorModel : PageModel
{
    /// <summary>
    /// Ruft die Kennung der aktuellen Anfrage ab oder legt sie fest.
    /// </summary>
    public string? RequestId { get; set; }

    /// <summary>
    /// Gibt an, ob eine Anfragenummer angezeigt werden kann.
    /// </summary>
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    /// <summary>
    /// Lädt die Fehlerseite und ermittelt die Kennung der aktuellen Anfrage.
    /// </summary>
    public void OnGet()
    {
        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
    }
}