using Microsoft.AspNetCore.Mvc.RazorPages;

public class AutorHinzufügenModel : PageModel
{
    public void OnPost(string name)
    {
        // neuen Datensatz anlegen
        var autor = new Autor
        {
            Name = name
        };

        var db = new Db();

        db.Autoren.Add(autor);

        // Erst bei SaveChanges() werden Änderungen, die wir an unseren Objekten
        // vorgenommen haben, bzw. neue Entitäten auch tatsächlich übernommen
        // und in die Datenbank geschrieben
        db.SaveChanges();
    }
}