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