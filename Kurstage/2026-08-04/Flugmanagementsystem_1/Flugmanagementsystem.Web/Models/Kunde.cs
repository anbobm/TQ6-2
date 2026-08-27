namespace Flugmanagementsystem.Web.Models;

/// <summary>
/// Repräsentiert einen Kunden mit seinen persönlichen Daten.
/// </summary>
public class Kunde
{
    /// <summary>
    /// Ruft die eindeutige Kennung des Kunden ab oder legt sie fest.
    /// </summary>
    public int KundeId { get; set; }

    /// <summary>
    /// Ruft den Vornamen des Kunden ab oder legt ihn fest.
    /// </summary>
    public string Vorname { get; set; } = string.Empty;

    /// <summary>
    /// Ruft den Nachnamen des Kunden ab oder legt ihn fest.
    /// </summary>
    public string Nachname { get; set; } = string.Empty;

    /// <summary>
    /// Ruft die E-Mail-Adresse des Kunden ab oder legt sie fest.
    /// </summary>
    public string Email { get; set; } = string.Empty;
}