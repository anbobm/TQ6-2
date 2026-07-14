using System.Collections.Generic;
using System.Linq;

public class Abteilung
{
    private List<Mitarbeiter> mitarbeiter;
    private ILogger logger;

    public string Bezeichnung { get; }

    public List<Mitarbeiter> Mitarbeiter
    {
        get { return mitarbeiter.ToList(); }
    }

    public Abteilung(string bezeichnung, ILogger logger)
    {
        Bezeichnung = bezeichnung;
        this.logger = logger;
        mitarbeiter = new List<Mitarbeiter>();
    }

    public void MitarbeiterHinzufügen(Mitarbeiter mitarbeiter)
    {
        if (mitarbeiter.Abteilung != null)
        {
            return;
        }

        this.mitarbeiter.Add(mitarbeiter);
        mitarbeiter.AbteilungSetzen(this);
        logger.Log($"Mitarbeiter {mitarbeiter.Name} wurde zur Abteilung {Bezeichnung} hinzugefügt.");
    }

    public void MitarbeiterEntfernen(Mitarbeiter mitarbeiter)
    {
        if (this.mitarbeiter.Remove(mitarbeiter))
        {
            mitarbeiter.AbteilungSetzen(null);
            logger.Log($"Mitarbeiter {mitarbeiter.Name} wurde aus der Abteilung {Bezeichnung} entfernt.");
        }
    }
}