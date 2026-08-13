public class Autor
{
    public int Id { get; set; }

    public string Name { get; set; }

    // Navigation Property
    public List<Buch> Bücher { get; set; }
}