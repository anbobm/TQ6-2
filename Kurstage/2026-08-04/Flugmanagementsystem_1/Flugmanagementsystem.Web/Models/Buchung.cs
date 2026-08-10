namespace Flugmanagementsystem.Web.Models;

public class Buchung
{
    public int BuchungId { get; set; }
    public int KundeId { get; set; }
    public int FlugId { get; set; }
    public DateTime Buchungsdatum { get; set; } = DateTime.Now;
    public string Status { get; set; } = "Bestätigt";
    public bool IstEingecheckt { get; set; }
}