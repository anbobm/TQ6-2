using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BiboApp.Pages;

public class IndexModel : PageModel
{
    private readonly Db _context;

    public List<Buch> Bücher { get; set; }

    public IndexModel(Db context)
    {
        _context = context;
    }

    public void OnGet()
    {
        Bücher = _context.Bücher.ToList();
    }
}
