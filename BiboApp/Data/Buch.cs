public class Buch
{
    public int Id { get; set; }

    public string Titel { get; set; }

    public int AutorId { get; set; }

    // Navigation Property
    public Autor Autor { get; set; }

    public List<Exemplar> Exemplare { get; set; }

    public List<Rubrik> Rubriken { get; set; }
}