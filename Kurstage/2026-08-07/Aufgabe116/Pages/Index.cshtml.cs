using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aufgabe116.Pages;

public class IndexModel : PageModel
{
    public string Begrüßung { get; set; }

    // http://localhost:5158/?vorname=
    public void OnGet(string vorname)
    {
        if (vorname == null)
        {
            return;
        }
        
        Begrüßung = $"Hallo {vorname}!";
    }
}
