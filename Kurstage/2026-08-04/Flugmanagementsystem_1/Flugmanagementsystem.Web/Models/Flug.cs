namespace Flugmanagementsystem.Web.Models;

public class Flug
{
    public int FlugId { get; set; }
    public string Flugnummer { get; set; } = string.Empty;
    public string Abflugort { get; set; } = string.Empty;
    public string Zielort { get; set; } = string.Empty;
    public DateTime Abflugzeit { get; set; }
    public DateTime Ankunftszeit { get; set; }
    public int AnzahlSitzplaetze { get; set; }
    public decimal MaximaleZuladung { get; set; }
    public decimal Preis { get; set; }
    public string Status { get; set; } = "Geplant";
}