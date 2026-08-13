using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BiboApp.Pages;

public class BücherModel : PageModel
{
    private readonly Db _context;

    public List<Buch> Bücher { get; set; } = new();

    public BücherModel(Db context)
    {
        _context = context;
    }

    public void OnGet()
    {
        Bücher = _context.Bücher.ToList();
    }
}
