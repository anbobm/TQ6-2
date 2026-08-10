namespace Flugmanagementsystem.Web.Models;

public class Kunde
{
    public int KundeId { get; set; }
    public string Vorname { get; set; } = string.Empty;
    public string Nachname { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}