using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class BuchDetailModel : PageModel
{
    Db db;

    public Buch Buch { get; set; }

    public BuchDetailModel(Db db)
    {
        this.db = db;
    }

    public void OnGet(int id)
    {
        Buch = db.Bücher
            .Include(buch => buch.Autor)
            .Include(buch => buch.Exemplare)
            .Include(buch => buch.Rubriken)
            .Where(buch => buch.Id == id)
            .FirstOrDefault();
    }
}