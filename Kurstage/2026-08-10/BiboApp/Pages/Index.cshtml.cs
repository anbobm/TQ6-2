using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BiboApp.Pages;

public class IndexModel : PageModel
{
    private readonly Db _context;

    public List<Buch> Bücher { get; private set; } = [];

    public IndexModel(Db context)
    {
        _context = context;
    }

    public void OnGet()
    {
        Bücher = _context.Bücher
            .Include(buch => buch.Autor)
            .ToList();
    }
}
