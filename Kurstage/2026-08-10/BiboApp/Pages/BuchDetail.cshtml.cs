using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BiboApp.Pages;

public class BuchDetailModel : PageModel
{
    private readonly Db _context;

    public Buch? Buch { get; private set; }

    public List<Exemplar> Exemplare { get; private set; } = [];

    public BuchDetailModel(Db context)
    {
        _context = context;
    }

    public void OnGet(int id)
    {
        Buch = _context.Bücher
            .Include(buch => buch.Autor)
            .FirstOrDefault(buch => buch.Id == id);

        Exemplare = _context.Exemplare
            .Where(exemplar => exemplar.BuchId == id)
            .ToList();
    }
}