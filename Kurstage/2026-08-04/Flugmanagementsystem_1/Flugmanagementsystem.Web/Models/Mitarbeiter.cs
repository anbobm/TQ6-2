namespace Flugmanagementsystem.Web.Models;

/// <summary>
/// Repräsentiert einen Mitarbeiter der Fluggesellschaft.
/// </summary>
public class Mitarbeiter
{
    /// <summary>
    /// Ruft die eindeutige Kennung des Mitarbeiters ab oder legt sie fest.
    /// </summary>
    public int MitarbeiterId { get; set; }

    /// <summary>
    /// Ruft den Vornamen des Mitarbeiters ab oder legt ihn fest.
    /// </summary>
    public string Vorname { get; set; } = string.Empty;

    /// <summary>
    /// Ruft den Nachnamen des Mitarbeiters ab oder legt ihn fest.
    /// </summary>
    public string Nachname { get; set; } = string.Empty;

    /// <summary>
    /// Ruft die eindeutige Personalnummer des Mitarbeiters ab oder legt sie fest.
    /// </summary>
    public string Personalnummer { get; set; } = string.Empty;
}