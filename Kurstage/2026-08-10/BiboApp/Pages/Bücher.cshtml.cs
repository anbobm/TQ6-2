using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BiboApp.Pages;

public class BücherModel : PageModel
{
    Db db;

    public List<Buch> Bücher { get; set; }

    public BücherModel(Db db)
    {
        this.db = db;
    }

    public void OnGet()
    {
        Bücher = db.Bücher
            .Include(buch => buch.Autor)
            .ToList();

        // // Beispiel für Bücher gefiltert anstatt alle
        // Bücher = db.Bücher
        //     .Where(buch => buch.Autor == "Michael Ende")
        //     .ToList();
    }
}
