public class Produkt
{
    public string Name { get; }

    private decimal preis;

    public decimal Preis
    {
        get
        {
            return preis;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Negative Preise sind nicht zulässig");
            }

            preis = value;
        }
    }

    public int Lagerbestand { get; private set; }

    public Produkt(string name, decimal preis)
    {
        Name = name;
        Preis = preis;
        Lagerbestand = 0;
    }

    public void Verkaufen(int menge)
    {
        if (menge < 0)
        {
            throw new ArgumentException("Negative Mengen nicht zulässig");
        }
        if (menge > Lagerbestand)
        {
            throw new ArgumentException("Lagerbestand nicht ausreichend");
        }

        Lagerbestand -= menge;
    }

    public void Nachbestellen(int menge)
    {
        if (menge < 0)
        {
            throw new ArgumentException("Negative Mengen nicht zulässig");
        }

        Lagerbestand += menge;
    }

    public string GetInfo()
    {
        return $"Produkt {Name}, Preis: {Preis}, Lagerbestand: {Lagerbestand}";
    }
}