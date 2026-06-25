public class Hotelzimmer
{
    private string zimmernummer;
    private int anzahlGaeste;
    private int maxGaeste;
    private string gastName;

    public Hotelzimmer(string zimmernummer)
    {
        this.zimmernummer = zimmernummer;
    }

    public int AnzahlGaeste
    {
        get
        {
            return anzahlGaeste;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Gästezahl kann nicht negativ sein");
            }

            if (value > maxGaeste)
            {
                throw new ArgumentException("Gästezahl kann nicht größer als Maximalbelegung sein");
            }

            anzahlGaeste = value;
        }
    }

    public int MaxGaeste
    {
        get
        {
            return maxGaeste;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Negative Maximalbelegung nicht erlaubt");
            }

            maxGaeste = value;
        }
    }

    public bool Belegt => anzahlGaeste > 0;

    public string GastName
    {
        get
        {
            return gastName;
        }
        set
        {
            if (value == "")
            {
                throw new ArgumentException("Leerer String als Gastname ist nicht erlaubt");
            }

            gastName = value;
        }
    }
}