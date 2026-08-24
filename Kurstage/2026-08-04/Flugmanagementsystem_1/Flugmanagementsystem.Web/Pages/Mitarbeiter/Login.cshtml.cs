using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Mitarbeiter;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Email { get; set; } = string.Empty;

    [BindProperty]
    public string Passwort { get; set; } = string.Empty;

    public string? Fehlermeldung { get; private set; }

    public void OnGet()
    {
    }

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

    public async Task<IActionResult> OnPostLogoutAsync()
    {
        await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);

        return RedirectToPage("/Index");
    }
}