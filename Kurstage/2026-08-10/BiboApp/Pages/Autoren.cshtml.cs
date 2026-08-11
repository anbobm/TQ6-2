using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class AutorenModel : PageModel
{
    Db db;

    public List<Autor> Autoren { get; set; }

    public AutorenModel(Db db)
    {
        this.db = db;
    }

    public void OnGet()
    {
        Autoren = db.Autoren.ToList();
        
        // als Beispiel: im Allgemeinen wollen wir nicht, wie oben,
        // alle Autoren aus der Datenbank holen, sondern nur einen Teil
        // davon, eventuell auch in einer konkreten Reihenfolge
        // Dafür können wir Where() und OrderBy()/OrderByDescending()
        // benutzen, die dann erwartungsgemäß in SQL übersetzt werden
        var gefilterteUndSortierteAutoren =
            db.Autoren
            .Where(autor => autor.Name.Contains("i"))
            .OrderByDescending(autor => autor.Name)
            .ToList();
    }
}