public class Exemplar
{
    public int Id { get; set; }

    public bool IstAusgeliehen { get; set; }

    public int BuchId { get; set; }

    public Buch Buch { get; set; }
}