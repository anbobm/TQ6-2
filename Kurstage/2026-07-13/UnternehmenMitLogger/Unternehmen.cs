using System.Collections.Generic;
using System.Linq;

public class Unternehmen
{
    private List<Abteilung> abteilungen;
    private ILogger logger;

    public string Name { get; }

    public List<Abteilung> Abteilungen
    {
        get { return abteilungen.ToList(); }
    }

    public Unternehmen(string name, ILogger logger)
    {
        Name = name;
        this.logger = logger;
        abteilungen = new List<Abteilung>();
    }

    public void AbteilungHinzufügen(Abteilung abteilung)
    {
        abteilungen.Add(abteilung);
        logger.Log($"Abteilung {abteilung.Bezeichnung} wurde zum Unternehmen {Name} hinzugefügt.");
    }

    public void AbteilungEntfernen(Abteilung abteilung)
    {
        if (abteilungen.Remove(abteilung))
        {
            logger.Log($"Abteilung {abteilung.Bezeichnung} wurde aus dem Unternehmen {Name} entfernt.");
        }
    }

    public Abteilung? AbteilungFinden(string bezeichnung)
    {
        return abteilungen.FirstOrDefault(a => a.Bezeichnung == bezeichnung);
    }

    public Mitarbeiter? MitarbeiterSuchen(string personalnummer)
    {
        var alleMitarbeiter = new List<Mitarbeiter>();

        foreach (var abteilung in abteilungen)
        {
            alleMitarbeiter.AddRange(abteilung.Mitarbeiter);
        }

        return alleMitarbeiter.FirstOrDefault(m => m.Personalnummer == personalnummer);
    }

    public Mitarbeiter? MitarbeiterErzeugen(string personalnummer, string name)
    {
        if (MitarbeiterSuchen(personalnummer) != null)
        {
            return null;
        }

        return new Mitarbeiter(personalnummer, name);
    }

    public void Info()
    {
        Console.WriteLine($"Unternehmen {Name}");

        foreach (var abteilung in abteilungen)
        {
            Console.WriteLine($"    Abteilung {abteilung.Bezeichnung}");

            foreach (var mitarbeiter in abteilung.Mitarbeiter.OrderBy(m => m.Personalnummer))
            {
                Console.WriteLine($"        {mitarbeiter.Personalnummer}: {mitarbeiter.Name}");
            }
        }
    }
}