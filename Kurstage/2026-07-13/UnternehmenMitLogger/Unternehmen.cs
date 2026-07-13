public class Unternehmen
{
    private List<Abteilung> abteilungen;

    private ILogger logger;

    public string Name { get; }

    public List<Abteilung> Abteilungen => abteilungen.ToList();

    public List<Mitarbeiter> Mitarbeiter
    {
        get
        {
            var mitarbeiter = new List<Mitarbeiter>();

            foreach (var abteilung in abteilungen)
            {
                mitarbeiter.AddRange(abteilung.Mitarbeiter);
            }

            return mitarbeiter;
        }
    }

    public Unternehmen(string name, ILogger logger)
    {
        Name = name;
        abteilungen = new List<Abteilung>();
        this.logger = logger;
    }

    public void AbteilungHinzufügen(Abteilung abteilung)
    {
        abteilungen.Add(abteilung);
        logger.Log($"Abteilung {abteilung.Bezeichnung} zugefügt");
    }

    public void AbteilungEntfernen(Abteilung abteilung)
    {
        abteilungen.Remove(abteilung);
        logger.Log($"Abteilung {abteilung.Bezeichnung} entfernt");
    }

    public Abteilung AbteilungFinden(string bezeichnung) => abteilungen.FirstOrDefault(a => a.Bezeichnung == bezeichnung);

    public void AlleMitarbeiterAnzeigen()
    {
        foreach (var m in Mitarbeiter)
        {
            Console.WriteLine($"{m.Personalnummer}: {m.Name}");
        }
    }

    public Mitarbeiter MitarbeiterSuchen(string personalnummer)
    {
        return Mitarbeiter.FirstOrDefault(m => m.Personalnummer == personalnummer);
    }

    public void Info()
    {
        Console.WriteLine($"Unternehmen: {Name}");

        foreach(var abteilung in abteilungen)
        {
            Console.WriteLine($"    Abteilung: {abteilung.Bezeichnung}");

            foreach (var mitarbeiter in abteilung.Mitarbeiter)
            {
                Console.WriteLine($"        Mitarbeiter: {mitarbeiter.Personalnummer} {mitarbeiter.Name}");
            }
        }
    }

    public Mitarbeiter MitarbeiterErzeugen(string personalnummer, string name)
    {
        if (MitarbeiterSuchen(personalnummer) != null)
        {
            return null;
        }
        else
        {
            return new Mitarbeiter(personalnummer, name);
        }
    }
}