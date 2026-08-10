namespace Flugmanagementsystem.Web.Models;

public class Mitarbeiter
{
    public int MitarbeiterId { get; set; }
    public string Vorname { get; set; } = string.Empty;
    public string Nachname { get; set; } = string.Empty;
    public string Personalnummer { get; set; } = string.Empty;
}