using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BiboApp.Pages;

public class BücherModel : PageModel
{
    private readonly Db _context;

    public List<Buch> Bücher { get; set; }

    public BücherModel(Db context)
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