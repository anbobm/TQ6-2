namespace Unternehmen;

public class Unternehmen
{
    private List<Abteilung> abteilungen;

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

    public Unternehmen(string name)
    {
        Name = name;
        abteilungen = new List<Abteilung>();
    }

    public void AbteilungHinzufügen(Abteilung abteilung)
    {
        abteilungen.Add(abteilung);
    }

    public void AbteilungEntfernen(Abteilung abteilung)
    {
        abteilungen.Remove(abteilung);
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

public class Abteilung
{
    private List<Mitarbeiter> mitarbeiter;

    public string Bezeichnung { get; }

    public List<Mitarbeiter> Mitarbeiter => mitarbeiter.ToList();

    public Abteilung(string bezeichnung)
    {
        Bezeichnung = bezeichnung;
        mitarbeiter = new List<Mitarbeiter>();
    }

    public void MitarbeiterHinzufügen(Mitarbeiter mitarbeiter)
    {
        this.mitarbeiter.Add(mitarbeiter);
        mitarbeiter.Abteilung = this;
    }

    public void MitarbeiterEntfernen(Mitarbeiter mitarbeiter)
    {
        this.mitarbeiter.Remove(mitarbeiter);
        mitarbeiter.Abteilung = null;
    }
}

public class Mitarbeiter
{
    public string Name { get; }

    public string Personalnummer { get; }

    public Abteilung Abteilung { get; set; }

    public Mitarbeiter(string personalnummer, string name)
    {
        Name = name;
        Personalnummer = personalnummer;
    }
}