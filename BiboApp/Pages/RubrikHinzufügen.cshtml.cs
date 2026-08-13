using Microsoft.AspNetCore.Mvc.RazorPages;

public class RubrikHinzufügenModel : PageModel
{
    Db db;

    public RubrikHinzufügenModel(Db db)
    {
        this.db = db;
    }

    public void OnPost(string name)
    {
        var rubrik = new Rubrik
        {
            Name = name
        };

        db.Rubriken.Add(rubrik);

        db.SaveChanges();
    }
}