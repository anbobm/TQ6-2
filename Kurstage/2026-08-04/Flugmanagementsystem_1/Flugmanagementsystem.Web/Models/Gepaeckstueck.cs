namespace Flugmanagementsystem.Web.Models;

/// <summary>
/// Repräsentiert ein Gepäckstück, das einer Buchung zugeordnet ist.
/// </summary>
public class Gepaeckstueck
{
    /// <summary>
    /// Ruft die eindeutige Kennung des Gepäckstücks ab oder legt sie fest.
    /// </summary>
    public int GepaeckstueckId { get; set; }

    /// <summary>
    /// Ruft die Kennung der zugehörigen Buchung ab oder legt sie fest.
    /// </summary>
    public int BuchungId { get; set; }

    /// <summary>
    /// Ruft das Gewicht des Gepäckstücks in Kilogramm ab oder legt es fest.
    /// </summary>
    public decimal Gewicht { get; set; }

    /// <summary>
    /// Gibt an, ob das Gewicht des Gepäckstücks 23 Kilogramm überschreitet.
    /// </summary>
    public bool IstUebergepaeck => Gewicht > 23m;

    /// <summary>
    /// Gibt den Gepäckzuschlag in Euro zurück.
    /// Bei Übergepäck beträgt der Zuschlag 50 Euro.
    /// </summary>
    public decimal Zuschlag =>
        IstUebergepaeck ? 50m : 0m;
}