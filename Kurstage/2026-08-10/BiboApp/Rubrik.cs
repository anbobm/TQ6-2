public class Rubrik
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<Buch> Bücher { get; set; } = [];
}