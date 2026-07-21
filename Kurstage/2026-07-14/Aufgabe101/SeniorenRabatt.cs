public class SeniorenRabatt : IRabatt
{
    public decimal RabattBerechnen(decimal gesamtpreis)
    {
        return gesamtpreis * 0.15m;
    }
}