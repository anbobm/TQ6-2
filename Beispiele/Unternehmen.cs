using System;
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

    public Abteilung? AbteilungFinden(string bezeichnung)
    {
        return abteilungen.FirstOrDefault(a => a.Bezeichnung == bezeichnung);
    }

    public void AlleMitarbeiterAnzeigen()
    {
        var alleMitarbeiter = new List<Mitarbeiter>();

        foreach (var abteilung in abteilungen)
        {
            alleMitarbeiter.AddRange(abteilung.Mitarbeiter);
        }

        foreach (var mitarbeiter in alleMitarbeiter.OrderBy(m => m.Personalnummer))
        {
            Console.WriteLine($"{mitarbeiter.Personalnummer}: {mitarbeiter.Name}");
        }
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


    public void Unternehmeninfo()
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
        if (mitarbeiter.Abteilung != null)
        {
            Console.WriteLine($"{mitarbeiter.Name} ist bereits in Abteilung {mitarbeiter.Abteilung.Bezeichnung}.");
            return;
        }

        this.mitarbeiter.Add(mitarbeiter);
        mitarbeiter.AbteilungSetzen(this);
    }

    public void MitarbeiterEntfernen(Mitarbeiter mitarbeiter)
    {
        if (this.mitarbeiter.Remove(mitarbeiter))
        {
            mitarbeiter.AbteilungSetzen(null);
        }
    }
}

public class Mitarbeiter
{
    public string Personalnummer { get; }
    public string Name { get; }
    public Abteilung? Abteilung { get; private set; }

    public Mitarbeiter(string personalnummer, string name)
    {
        Personalnummer = personalnummer;
        Name = name;
    }

    internal void AbteilungSetzen(Abteilung? abteilung)
    {
        Abteilung = abteilung;
    }
}



