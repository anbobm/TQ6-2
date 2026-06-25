public class Buch
{
    public string Titel { get; }
    public string Autor { get; }

    public Buch(string titel, string autor)
    {
        Titel = titel;
        Autor = autor;
    }

    public Buch(string titel)
    {
        Titel = titel;
        Autor = "Unbekannt";
    }
}