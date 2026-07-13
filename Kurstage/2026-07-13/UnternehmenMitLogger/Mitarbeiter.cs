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