using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class AutorDetailModel : PageModel
{
    Db db;

    public Autor Autor { get; set; }

    public AutorDetailModel(Db db)
    {
        this.db = db;
    }

    public void OnGet(int id)
    {
        Autor = db.Autoren
            .Include(autor => autor.Bücher)
            .Where(autor => autor.Id == id)
            .FirstOrDefault();
    }
}