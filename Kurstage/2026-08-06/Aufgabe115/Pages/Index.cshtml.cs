using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aufgabe115.Pages;

public class IndexModel : PageModel
{
    public string Begrüßung { get; set; }

    public void OnGet(DateTime? geburtsdatum)
    {
        if (!geburtsdatum.HasValue)
        {
            return;
        }

        var heute = DateTime.Now;

        if (geburtsdatum.Value.Month == heute.Month
            && geburtsdatum.Value.Day == heute.Day)
        {
            Begrüßung = "Alles Gute zum Geburtstag!";
        }
        else {
            Begrüßung = "Willkommen! (Sorry, keine Geschenke heute)";
        } 
    }
}
