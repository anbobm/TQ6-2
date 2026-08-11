using Microsoft.AspNetCore.Mvc.RazorPages;

public class AutorenModel : PageModel
{
    public List<Autor> Autoren { get; set; }

    public void OnGet()
    {
        var db = new Db();

        Autoren = db.Autoren.ToList();
    }
}