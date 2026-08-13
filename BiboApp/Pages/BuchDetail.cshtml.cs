using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class BuchDetailModel : PageModel
{
    Db db;

    public Buch Buch { get; set; }

    public List<Exemplar> Exemplare { get; set; }

    public BuchDetailModel(Db db)
    {
        this.db = db;
    }

    public void OnGet(int id)
    {
        Buch = db.Bücher
            .Include(buch => buch.Autor)
            .Where(buch => buch.Id == id)
            .FirstOrDefault();
        
        Exemplare = db.Exemplare
            .Where(exemplar => exemplar.BuchId == id)
            .ToList();
    }
}