public class Rechteck
{
    public int Breite
    {
        get;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Breite muss positiv sein.");
            }

            field = value;
        }
    }

    public int Hoehe
    {
        get;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Hoehe muss positiv sein.");
            }
            
            field = value;
        }
    }

    public int Flaeche => Breite * Hoehe;

    public int Umfang => 2 * (Breite + Hoehe);

    public Rechteck(int breite, int hoehe)
    {
        Breite = breite;
        Hoehe = hoehe;
    }
}