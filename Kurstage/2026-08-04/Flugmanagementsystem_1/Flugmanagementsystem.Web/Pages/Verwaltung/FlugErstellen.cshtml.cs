using System.Globalization;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Verwaltung;

public class FlugErstellenModel : PageModel
{
    private readonly FlightService _flightService;

    [TempData]
    public string? Fehlermeldung { get; set; }

    public FlugErstellenModel(FlightService flightService)
    {
        _flightService = flightService;
    }

    public void OnGet()
    {
    }

    public IActionResult OnPost(
        string flugnummer,
        string abflugort,
        string zielort,
        DateTime abflugzeit,
        DateTime ankunftszeit,
        int anzahlSitzplaetze,
        decimal maximaleZuladung,
        string preis)
    {
        decimal preisWert;

        var preisIstGueltig =
            decimal.TryParse(
                preis,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out preisWert)
            ||
            decimal.TryParse(
                preis,
                NumberStyles.Number,
                CultureInfo.GetCultureInfo("de-DE"),
                out preisWert);

        if (!preisIstGueltig || preisWert <= 0)
        {
            Fehlermeldung =
                "Der Preis muss größer als 0 sein.";
            return RedirectToPage();
        }

        if (abflugzeit <= DateTime.Now)
        {
            Fehlermeldung =
                "Die Abflugzeit muss in der Zukunft liegen.";
            return RedirectToPage();
        }

        if (ankunftszeit <= abflugzeit)
        {
            Fehlermeldung =
                "Die Ankunftszeit muss nach der Abflugzeit liegen.";
            return RedirectToPage();
        }

        if (anzahlSitzplaetze <= 0)
        {
            Fehlermeldung =
                "Die Anzahl der Sitzplätze muss größer als 0 sein.";
            return RedirectToPage();
        }

        if (maximaleZuladung <= 0)
        {
            Fehlermeldung =
                "Die maximale Zuladung muss größer als 0 sein.";
            return RedirectToPage();
        }

        var flug = _flightService.CreateFlug(
            flugnummer,
            abflugort,
            zielort,
            abflugzeit,
            ankunftszeit,
            anzahlSitzplaetze,
            maximaleZuladung,
            preisWert);

        if (flug is null)
        {
            Fehlermeldung =
                "Die Flugnummer existiert bereits oder Angaben sind ungültig.";
            return RedirectToPage();
        }

        return RedirectToPage(
            "/Fluege/Details",
            new { id = flug.FlugId });
    }
}