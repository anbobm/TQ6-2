using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BiboApp.Pages;

public class BuchHinzufügenModel : PageModel
{
    private readonly Db _context;

    public List<Autor> Autoren { get; set; }

    public BuchHinzufügenModel(Db context)
    {
        _context = context;
        Autoren = _context.Autoren.ToList();
    }

    public void OnPost(string titel, int autorId)
    {
        var autor = _context.Autoren
            .FirstOrDefault(a => a.Id == autorId);

        if (autor == null)
        {
            return;
        }

        var buch = new Buch
        {
            Titel = titel,
            Autor = autor
        };

        _context.Bücher.Add(buch);
        _context.SaveChanges();
    }
}