using System.Globalization;
using Flugmanagementsystem.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flugmanagementsystem.Web.Pages.Verwaltung;

/// <summary>
/// Stellt die Seite zum Bearbeiten eines aktiven Fluges bereit.
/// </summary>
public class FlugBearbeitenModel : PageModel
{
    private readonly FlightService _flightService;

    /// <summary>
    /// Ruft die Kennung des zu bearbeitenden Fluges ab oder legt sie fest.
    /// </summary>
    [BindProperty]
    public int FlugId { get; set; }

    /// <summary>
    /// Ruft die Flugnummer des ausgewählten Fluges ab.
    /// </summary>
    public string Flugnummer { get; private set; } = string.Empty;

    /// <summary>
    /// Ruft den Abflugort ab oder legt ihn fest.
    /// </summary>
    [BindProperty]
    public string Abflugort { get; set; } = string.Empty;

    /// <summary>
    /// Ruft den Zielort ab oder legt ihn fest.
    /// </summary>
    [BindProperty]
    public string Zielort { get; set; } = string.Empty;

    /// <summary>
    /// Ruft die Abflugzeit ab oder legt sie fest.
    /// </summary>
    [BindProperty]
    public DateTime Abflugzeit { get; set; }

    /// <summary>
    /// Ruft die Ankunftszeit ab oder legt sie fest.
    /// </summary>
    [BindProperty]
    public DateTime Ankunftszeit { get; set; }

    /// <summary>
    /// Ruft die Anzahl der Sitzplätze ab oder legt sie fest.
    /// </summary>
    [BindProperty]
    public int AnzahlSitzplaetze { get; set; }

    /// <summary>
    /// Ruft die maximale Zuladung in Kilogramm ab oder legt sie fest.
    /// </summary>
    [BindProperty]
    public decimal MaximaleZuladung { get; set; }

    /// <summary>
    /// Ruft den Ticketpreis als Texteingabe ab oder legt ihn fest.
    /// </summary>
    [BindProperty]
    public string Preis { get; set; } = string.Empty;

    /// <summary>
    /// Ruft eine Fehlermeldung nach einer ungültigen Bearbeitung ab.
    /// </summary>
    public string? Fehlermeldung { get; private set; }

    /// <summary>
    /// Initialisiert die Seite zum Bearbeiten eines Fluges.
    /// </summary>
    /// <param name="flightService">Der Dienst zur Verwaltung von Flügen.</param>
    public FlugBearbeitenModel(FlightService flightService)
    {
        _flightService = flightService;
    }

    /// <summary>
    /// Lädt die vorhandenen Daten eines aktiven Fluges in das Formular.
    /// </summary>
    /// <param name="id">Die Kennung des Fluges.</param>
    /// <returns>
    /// Die Bearbeitungsseite oder eine Fehlerseite, wenn der Flug nicht
    /// vorhanden oder bereits storniert ist.
    /// </returns>
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

    /// <summary>
    /// Prüft die Formulardaten und speichert die Änderungen am Flug.
    /// </summary>
    /// <returns>
    /// Die Bearbeitungsseite bei ungültigen Daten oder eine Weiterleitung
    /// zur Flugverwaltung nach erfolgreicher Speicherung.
    /// </returns>
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