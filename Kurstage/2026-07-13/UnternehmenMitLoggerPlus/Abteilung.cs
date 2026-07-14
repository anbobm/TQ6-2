public class Abteilung
{
    private List<Mitarbeiter> mitarbeiter;
    private ILogger logger;

    public string Bezeichnung { get; }

    public List<Mitarbeiter> Mitarbeiter => mitarbeiter.ToList();

    public Abteilung(string bezeichnung, ILogger logger)
    {
        Bezeichnung = bezeichnung;
        mitarbeiter = new List<Mitarbeiter>();
        this.logger = logger;
    }

    public void MitarbeiterHinzufügen(Mitarbeiter mitarbeiter)
    {
        this.mitarbeiter.Add(mitarbeiter);
        mitarbeiter.Abteilung = this;
        logger.Log($"Mitarbeiter {mitarbeiter.Name} zugefügt");
    }

    public void MitarbeiterEntfernen(Mitarbeiter mitarbeiter)
    {
        this.mitarbeiter.Remove(mitarbeiter);
        mitarbeiter.Abteilung = null;
        logger.Log($"Mitarbeiter {mitarbeiter.Name} entfernt");
    }
}