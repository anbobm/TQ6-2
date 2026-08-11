namespace Aufgabe118.Models;

public class Artikel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Beschreibung { get; set; } = string.Empty;
    public decimal Preis { get; set; }
}