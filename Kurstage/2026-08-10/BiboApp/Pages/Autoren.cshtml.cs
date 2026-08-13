using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BiboApp.Pages;

public class AutorenModel : PageModel
{
    private readonly Db _context;

    public List<Autor> Autoren { get; set; }

    public AutorenModel(Db context)
    {
        _context = context;
    }

    public void OnGet()
    {
        Autoren = _context.Autoren.ToList();
    }
}
