using Microsoft.AspNetCore.Mvc.RazorPages;

public class BuchHinzufügenModel : PageModel
{
    Db db;

    public List<Autor> Autoren { get; set; }

    public BuchHinzufügenModel(Db db)
    {
        this.db = db;
        Autoren = db.Autoren.ToList();
    }

    public void OnPost(string titel, int autorId)
    {
        var autorObjekt = db.Autoren.Where(a => a.Id == autorId).FirstOrDefault();

        if (autorObjekt == null)
        {
            return;
        }

        var buch = new Buch
        {
            Titel = titel,
            Autor = autorObjekt
        };

        db.Bücher.Add(buch);

        db.SaveChanges();
    }
}