using System.Collections.Generic;
using System.Linq;

namespace Unternehmen;

public class Unternehmen
{
    private List<Abteilung> abteilungen;

    public string Name { get; }

    public List<Abteilung> Abteilungen
    {
        get { return abteilungen.ToList(); }
    }

    public Unternehmen(string name)
    {
        Name = name;
        abteilungen = new List<Abteilung>();
    }

    public void AbteilungHinzufuegen(Abteilung abteilung)
    {
        abteilungen.Add(abteilung);
    }

    public void AbteilungEntfernen(Abteilung abteilung)
    {
        abteilungen.Remove(abteilung);
    }
}

public class Abteilung
{
    private List<Mitarbeiter> mitarbeiter;

    public string Bezeichnung { get; }

    public List<Mitarbeiter> Mitarbeiter
    {
        get { return mitarbeiter.ToList(); }
    }

    public Abteilung(string bezeichnung)
    {
        Bezeichnung = bezeichnung;
        mitarbeiter = new List<Mitarbeiter>();
    }

    public void MitarbeiterHinzufuegen(Mitarbeiter mitarbeiter)
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
    public string Personalnummer { get; }
    public string Name { get; }

    public Mitarbeiter(string personalnummer, string name)
    {
        Personalnummer = personalnummer;
        Name = name;
    }
}