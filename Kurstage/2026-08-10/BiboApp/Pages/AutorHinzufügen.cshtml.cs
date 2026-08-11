using Microsoft.AspNetCore.Mvc.RazorPages;

public class AutorHinzufügenModel : PageModel
{
    Db db;

    public AutorHinzufügenModel(Db db)
    {
        this.db = db;
    }

    public void OnPost(string name)
    {
        // neuen Datensatz anlegen
        var autor = new Autor
        {
            Name = name
        };
        
        db.Autoren.Add(autor);

        // Erst bei SaveChanges() werden Änderungen, die wir an unseren Objekten
        // vorgenommen haben, bzw. neue Entitäten auch tatsächlich übernommen
        // und in die Datenbank geschrieben
        db.SaveChanges();
    }
}