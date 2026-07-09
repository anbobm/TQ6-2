namespace Bibliothek;

public class Medium
{
    public string Titel { get; }

    public bool IstAusgeliehen => AusgeliehenVon != null;

    public Benutzer AusgeliehenVon { get; private set; }

    public Medium(string titel)
    {
        Titel = titel;
    }

    public void Ausleihen(Benutzer benutzer)
    {
        AusgeliehenVon = benutzer;
    }

    public void Zurueckgeben()
    {
        AusgeliehenVon = null;
    }
}

public class Buch : Medium
{
    public int Seitenzahl { get; }

    public string Autor { get; }

    public Buch(string titel, int seitenzahl, string autor) : base(titel)
    {
        Seitenzahl = seitenzahl;
        Autor = autor;
    }
}

public class Dvd : Medium
{
    public int Laufzeit { get; }

    public string Regisseur { get; }

    public Dvd(string titel, int laufzeit, string regisseur) : base(titel)
    {
        Laufzeit = laufzeit;
        Regisseur = regisseur;
    }
}

public class Bibliothek
{
    private List<Medium> medien;

    public List<Medium> Medien => medien.ToList();

    public List<Medium> AusgelieheneMedien
    {
        get
        {
            var ausgeliehen = new List<Medium>();

            foreach (var medium in medien)
            {
                if (medium.IstAusgeliehen)
                {
                    ausgeliehen.Add(medium);
                }
            }

            return ausgeliehen;
        }
    }

    // // Alternative:
    // public List<Medium> AusgelieheneMedien => medien.Where(m => m.IstAusgeliehen).ToList();

    public Bibliothek()
    {
        medien = new List<Medium>();
    }

    public void Hinzufuegen(Medium medium)
    {
        medien.Add(medium);
    }
}

public class Benutzer
{
    public string Name { get; }

    public Benutzer(string name)
    {
        Name = name;
    }
}