using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aufgabe116.Pages;

public class IndexModel : PageModel
{
    public string Begruessung { get; set; } = "";

    public void OnGet(string? name)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            Begruessung = $"Hallo, {name}!";
        }
    }
}
