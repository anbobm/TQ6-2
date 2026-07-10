namespace Unternehmen;

public class Unternehmen
{
    private List<Abteilung> abteilungen;

    public string Name { get; }

    public List<Abteilung> Abteilungen => abteilungen.ToList();

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
        var mitarbeiter = new List<Mitarbeiter>();

        foreach (var abteilung in abteilungen)
        {
            mitarbeiter.AddRange(abteilung.Mitarbeiter);
        }

        foreach (var m in mitarbeiter)
        {
            Console.WriteLine($"{m.Personalnummer}: {m.Name}");
        }
    }

    public Mitarbeiter MitarbeiterSuchen(string personalnummer)
    {
        var mitarbeiter = new List<Mitarbeiter>();

        foreach (var abteilung in abteilungen)
        {
            mitarbeiter.AddRange(abteilung.Mitarbeiter);
        }

        return mitarbeiter.FirstOrDefault(m => m.Personalnummer == personalnummer);
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
    }

    public void MitarbeiterEntfernen(Mitarbeiter mitarbeiter)
    {
        this.mitarbeiter.Remove(mitarbeiter);
    }
}

public class Mitarbeiter
{
    public string Name { get; }

    public string Personalnummer { get; }

    public Mitarbeiter(string personalnummer, string name)
    {
        Name = name;
        Personalnummer = personalnummer;
    }
}