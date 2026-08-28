using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Mitarbeiter;

/// <summary>
/// Stellt die Anmeldeseite für Mitarbeiter von GermanyFly bereit.
/// </summary>
public class LoginModel : PageModel
{
    /// <summary>
    /// Ruft die eingegebene E-Mail-Adresse ab oder legt sie fest.
    /// </summary>
    [BindProperty]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Ruft das eingegebene Passwort ab oder legt es fest.
    /// </summary>
    [BindProperty]
    public string Passwort { get; set; } = string.Empty;

    /// <summary>
    /// Ruft eine Fehlermeldung nach einer fehlgeschlagenen Anmeldung ab.
    /// </summary>
    public string? Fehlermeldung { get; private set; }

    /// <summary>
    /// Lädt die Anmeldeseite.
    /// </summary>
    public void OnGet()
    {
    }

    /// <summary>
    /// Prüft die Anmeldedaten und meldet den Mitarbeiter bei Erfolg an.
    /// </summary>
    /// <returns>
    /// Die Anmeldeseite bei ungültigen Daten oder eine Weiterleitung
    /// zum Verwaltungsbereich bei erfolgreicher Anmeldung.
    /// </returns>
    public async Task<IActionResult> OnPostAsync()
    {
        var istMitarbeiter =
            Email.Equals(
                "mitarbeiter@germanyfly.de",
                StringComparison.OrdinalIgnoreCase) &&
            Passwort == "GermanyFly2026!";

        if (!istMitarbeiter)
        {
            Fehlermeldung = "E-Mail oder Passwort ist nicht korrekt.";
            return Page();
        }

        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, "GermanyFly Mitarbeiter"),
            new(ClaimTypes.Role, "Mitarbeiter")
        };

        var identity = new ClaimsIdentity(
            claims,
            CookieAuthenticationDefaults.AuthenticationScheme);

        var principal = new ClaimsPrincipal(identity);

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            principal);

        return RedirectToPage("/Verwaltung/Fluege");
    }

    /// <summary>
    /// Meldet den aktuellen Mitarbeiter ab.
    /// </summary>
    /// <returns>Eine Weiterleitung zur Startseite.</returns>
    public async Task<IActionResult> OnPostLogoutAsync()
    {
        await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);

        return RedirectToPage("/Index");
    }
}