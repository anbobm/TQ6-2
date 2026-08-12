using Microsoft.AspNetCore.Mvc.RazorPages;

public class BuchHinzufügenModel : PageModel
{
    Db db;

    public BuchHinzufügenModel(Db db)
    {
        this.db = db;
    }

    public void OnPost(string titel, string autor)
    {
        var buch = new Buch
        {
            Titel = titel,
            Autor = autor
        };

        db.Bücher.Add(buch);

        db.SaveChanges();
    }
}