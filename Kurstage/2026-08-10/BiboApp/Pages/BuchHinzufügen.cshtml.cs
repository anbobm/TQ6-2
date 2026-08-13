using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BiboApp.Pages;

public class BuchHinzufügenModel : PageModel
{
    private readonly Db _context;

    public BuchHinzufügenModel(Db context)
    {
        _context = context;
    }

    public void OnPost(string titel, string autor)
    {
        var buch = new Buch
        {
            Titel = titel,
            Autor = autor
        };

        _context.Bücher.Add(buch);
        _context.SaveChanges();
    }
}