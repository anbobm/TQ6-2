using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aufgabe117.Pages;

public class IndexModel : PageModel
{
    public Artikel Artikel { get; private set; }

    public Artikel[] ArtikelListe { get; } =
        [
            new Artikel {
                Id = 1,
                Name = "Klimaanlage",
                Beschreibung = "Klimaanlage, die Luft kalt macht",
                Preis = 1500
            },
            new Artikel {
                Id = 2,
                Name = "Eismaschine",
                Beschreibung = "Hmm, lecker!",
                Preis = 39.95m
            },
            new Artikel {
                Id = 3,
                Name = "Kaffeemaschine",
                Beschreibung = "Hmm, lecker!",
                Preis = 195.95m
            },
            new Artikel {
                Id = 4,
                Name = "Waschmaschine",
                Beschreibung = "Dreht schön",
                Preis = 499.95m
            }
        ];

    public void OnGet(int id)
    {
        Artikel = ArtikelListe.FirstOrDefault(artikel => artikel.Id == id);
    }
}
