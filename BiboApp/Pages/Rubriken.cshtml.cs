using Microsoft.AspNetCore.Mvc.RazorPages;

public class RubrikenModel : PageModel
{
    Db db;

    public List<Rubrik> Rubriken { get; set; }

    public RubrikenModel(Db db)
    {
        this.db = db;
    }

    public void OnGet()
    {
        Rubriken = db.Rubriken.ToList();
    }
}