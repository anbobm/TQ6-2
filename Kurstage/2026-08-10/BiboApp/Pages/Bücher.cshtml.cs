using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BiboApp.Pages;

public class BücherModel : PageModel
{
    public List<Buch> Bücher { get; set; }

    public void OnGet()
    {
        var db = new Db();

        Bücher = db.Bücher.ToList();
    }
}
