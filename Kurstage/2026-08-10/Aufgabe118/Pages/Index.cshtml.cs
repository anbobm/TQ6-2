using Aufgabe118.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aufgabe118.Pages;

public class IndexModel : PageModel
{
    public Artikel[] ArtikelListe { get; } =
    [
        new Artikel
        {
            Id = 1,
            Name = "Klimaanlage",
            Beschreibung = "Klimaanlage, die Luft kalt macht",
            Preis = 1500
        },
        new Artikel
        {
            Id = 2,
            Name = "Eismaschine",
            Beschreibung = "Hmm, lecker!",
            Preis = 39.95m
        },
        new Artikel
        {
            Id = 3,
            Name = "Kaffeemaschine",
            Beschreibung = "Hmm, lecker!",
            Preis = 195.95m
        },
        new Artikel
        {
            Id = 4,
            Name = "Waschmaschine",
            Beschreibung = "Dreht schön",
            Preis = 499.95m
        }
    ];

    public Artikel? AusgewaehlterArtikel { get; private set; }

    public void OnGet(int? id)
    {
        if (id.HasValue)
        {
            AusgewaehlterArtikel =
                ArtikelListe.FirstOrDefault(artikel => artikel.Id == id.Value);
        }
    }
}