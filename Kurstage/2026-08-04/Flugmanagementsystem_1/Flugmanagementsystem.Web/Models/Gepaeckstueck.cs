namespace Flugmanagementsystem.Web.Models;

public class Gepaeckstueck
{
    public int GepaeckstueckId { get; set; }
    public int BuchungId { get; set; }
    public decimal Gewicht { get; set; }

    public bool IstUebergepaeck => Gewicht > 23m;

public decimal Zuschlag =>
    IstUebergepaeck ? 50m : 0m;
}