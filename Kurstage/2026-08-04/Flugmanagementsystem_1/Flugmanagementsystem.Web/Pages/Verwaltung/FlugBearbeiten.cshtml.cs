using System.Globalization;
using Flugmanagementsystem.Web.Models;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Verwaltung;

public class FlugBearbeitenModel : PageModel
{
    private readonly FlightService _flightService;

    [BindProperty]
    public int FlugId { get; set; }

    public string Flugnummer { get; private set; } = string.Empty;

    [BindProperty]
    public string Abflugort { get; set; } = string.Empty;

    [BindProperty]
    public string Zielort { get; set; } = string.Empty;

    [BindProperty]
    public DateTime Abflugzeit { get; set; }

    [BindProperty]
    public DateTime Ankunftszeit { get; set; }

    [BindProperty]
    public int AnzahlSitzplaetze { get; set; }

    [BindProperty]
    public decimal MaximaleZuladung { get; set; }

    [BindProperty]
    public string Preis { get; set; } = string.Empty;

    public string? Fehlermeldung { get; private set; }

    public FlugBearbeitenModel(FlightService flightService)
    {
        _flightService = flightService;
    }

    public IActionResult OnGet(int id)
    {
        var flug = _flightService.GetFlugById(id);

        if (flug is null || flug.Status == "Storniert")
        {
            return NotFound();
        }

        FlugId = flug.FlugId;
        Flugnummer = flug.Flugnummer;
        Abflugort = flug.Abflugort;
        Zielort = flug.Zielort;
        Abflugzeit = flug.Abflugzeit;
        Ankunftszeit = flug.Ankunftszeit;
        AnzahlSitzplaetze = flug.AnzahlSitzplaetze;
        MaximaleZuladung = flug.MaximaleZuladung;
        Preis = flug.Preis.ToString("0.00", CultureInfo.InvariantCulture);

        return Page();
    }

    public IActionResult OnPost()
    {
        var preisIstGueltig =
            decimal.TryParse(
                Preis,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out var preis)
            || decimal.TryParse(
                Preis,
                NumberStyles.Number,
                CultureInfo.GetCultureInfo("de-DE"),
                out preis);

        if (!preisIstGueltig)
        {
            Fehlermeldung = "Bitte gib einen gültigen Preis ein.";
            return Page();
        }

        var wurdeBearbeitet = _flightService.BearbeiteFlug(
            FlugId,
            Abflugort,
            Zielort,
            Abflugzeit,
            Ankunftszeit,
            AnzahlSitzplaetze,
            MaximaleZuladung,
            preis);

        if (!wurdeBearbeitet)
        {
            Fehlermeldung =
                "Der Flug konnte nicht geändert werden. Prüfe alle Angaben.";
            return Page();
        }

        return RedirectToPage("/Verwaltung/Fluege");
    }
}