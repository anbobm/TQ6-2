using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class RubrikZuweisenModel : PageModel
{
    Db db;

    public RubrikZuweisenModel(Db db)
    {
        this.db = db;
    }

    public void OnPost(int buchid, int rubrikid)
    {
        var buch = db.Bücher
            .Include(buch => buch.Rubriken)
            .Where(buch => buch.Id == buchid)
            .FirstOrDefault();
        var rubrik = db.Rubriken
            .Where(rubrik => rubrik.Id == rubrikid)
            .FirstOrDefault();

        if (buch == null || rubrik == null)
        {
            return;
        }

        buch.Rubriken.Add(rubrik);

        db.SaveChanges();
    }
}