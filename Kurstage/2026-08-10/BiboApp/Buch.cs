public class Buch
{
    public int Id { get; set; }

    public string Titel { get; set; }

    public int AutorId { get; set; }

    public Autor Autor { get; set; }

    public List<Rubrik> Rubriken { get; set; } = [];
}