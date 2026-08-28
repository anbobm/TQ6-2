using System.Globalization;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Verwaltung;

/// <summary>
/// Stellt die Seite zum Erstellen eines neuen Fluges bereit.
/// </summary>
public class FlugErstellenModel : PageModel
{
    private readonly FlightService _flightService;

    /// <summary>
    /// Ruft eine Fehlermeldung ab oder legt sie fest.
    /// Die Meldung bleibt nach einer Weiterleitung verfügbar.
    /// </summary>
    [TempData]
    public string? Fehlermeldung { get; set; }

    /// <summary>
    /// Initialisiert die Seite zum Erstellen eines Fluges.
    /// </summary>
    /// <param name="flightService">Der Dienst zur Verwaltung von Flügen.</param>
    public FlugErstellenModel(FlightService flightService)
    {
        _flightService = flightService;
    }

    /// <summary>
    /// Lädt das Formular zum Erstellen eines Fluges.
    /// </summary>
    public void OnGet()
    {
    }

    /// <summary>
    /// Prüft die Formulardaten und erstellt einen neuen Flug.
    /// </summary>
    /// <param name="flugnummer">Die eindeutige Flugnummer.</param>
    /// <param name="abflugort">Der Abflugort.</param>
    /// <param name="zielort">Der Zielort.</param>
    /// <param name="abflugzeit">Die Abflugzeit.</param>
    /// <param name="ankunftszeit">Die Ankunftszeit.</param>
    /// <param name="anzahlSitzplaetze">Die Anzahl der Sitzplätze.</param>
    /// <param name="maximaleZuladung">Die maximale Zuladung in Kilogramm.</param>
    /// <param name="preis">Der Ticketpreis als Texteingabe.</param>
    /// <returns>
    /// Eine Weiterleitung zur Erstellungsseite bei ungültigen Daten oder
    /// zur Detailseite des neuen Fluges nach erfolgreicher Erstellung.
    /// </returns>
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