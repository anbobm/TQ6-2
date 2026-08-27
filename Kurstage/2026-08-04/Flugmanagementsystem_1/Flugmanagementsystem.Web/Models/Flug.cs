namespace Flugmanagementsystem.Web.Models;

/// <summary>
/// Repräsentiert einen Flug mit seinen Flug-, Zeit-, Kapazitäts- und Preisdaten.
/// </summary>
public class Flug
{
    /// <summary>
    /// Ruft die eindeutige Kennung des Fluges ab oder legt sie fest.
    /// </summary>
    public int FlugId { get; set; }

    /// <summary>
    /// Ruft die Flugnummer ab oder legt sie fest.
    /// </summary>
    public string Flugnummer { get; set; } = string.Empty;

    /// <summary>
    /// Ruft den Abflugort ab oder legt ihn fest.
    /// </summary>
    public string Abflugort { get; set; } = string.Empty;

    /// <summary>
    /// Ruft den Zielort ab oder legt ihn fest.
    /// </summary>
    public string Zielort { get; set; } = string.Empty;

    /// <summary>
    /// Ruft das Datum und die Uhrzeit des Abflugs ab oder legt sie fest.
    /// </summary>
    public DateTime Abflugzeit { get; set; }

    /// <summary>
    /// Ruft das Datum und die Uhrzeit der Ankunft ab oder legt sie fest.
    /// </summary>
    public DateTime Ankunftszeit { get; set; }

    /// <summary>
    /// Ruft die Anzahl der verfügbaren Sitzplätze ab oder legt sie fest.
    /// </summary>
    public int AnzahlSitzplaetze { get; set; }

    /// <summary>
    /// Ruft die maximal zulässige Zuladung des Fluges in Kilogramm ab
    /// oder legt sie fest.
    /// </summary>
    public decimal MaximaleZuladung { get; set; }

    /// <summary>
    /// Ruft den Preis eines Flugtickets ab oder legt ihn fest.
    /// </summary>
    public decimal Preis { get; set; }

    /// <summary>
    /// Ruft den Flugstatus ab oder legt ihn fest.
    /// Der Standardwert ist <c>Geplant</c>.
    /// </summary>
    public string Status { get; set; } = "Geplant";
}