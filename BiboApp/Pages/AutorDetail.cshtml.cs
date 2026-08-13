using Microsoft.AspNetCore.Mvc.RazorPages;

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
        Autor = db.Autoren.Where(autor => autor.Id == id).FirstOrDefault();
    }
}