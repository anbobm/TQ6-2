namespace Flugmanagementsystem.Web.Models;

/// <summary>
/// Repräsentiert eine Buchung und verbindet einen Kunden mit einem Flug.
/// </summary>
public class Buchung
{
    /// <summary>
    /// Ruft die eindeutige Kennung der Buchung ab oder legt sie fest.
    /// </summary>
    public int BuchungId { get; set; }

    /// <summary>
    /// Ruft die Kennung des zugehörigen Kunden ab oder legt sie fest.
    /// </summary>
    public int KundeId { get; set; }

    /// <summary>
    /// Ruft die Kennung des gebuchten Fluges ab oder legt sie fest.
    /// </summary>
    public int FlugId { get; set; }

    /// <summary>
    /// Ruft das Datum und die Uhrzeit der Buchung ab oder legt sie fest.
    /// Der Standardwert ist der aktuelle Zeitpunkt.
    /// </summary>
    public DateTime Buchungsdatum { get; set; } = DateTime.Now;

    /// <summary>
    /// Ruft den Buchungsstatus ab oder legt ihn fest.
    /// Der Standardwert ist <c>Bestätigt</c>.
    /// </summary>
    public string Status { get; set; } = "Bestätigt";

    /// <summary>
    /// Ruft ab oder legt fest, ob der Online-Check-in durchgeführt wurde.
    /// </summary>
    public bool IstEingecheckt { get; set; }
}