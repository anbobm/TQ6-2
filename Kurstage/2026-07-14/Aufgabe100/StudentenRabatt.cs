public class StudentenRabatt : IRabatt
{
    public decimal RabattBerechnen(decimal gesamtpreis)
    {
        return gesamtpreis * 0.1m;
    }
}