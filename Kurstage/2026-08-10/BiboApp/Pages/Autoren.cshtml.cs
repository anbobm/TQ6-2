using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BiboApp.Pages;

public class AutorenModel : PageModel
{
    public List<Autor> Autoren { get; set; }

    public void OnGet()
    {
        var db = new Db();

        Autoren = db.Autoren.ToList();
    }
}