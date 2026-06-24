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

    public int GetAnzahlGaeste()
    {
        return anzahlGaeste;
    }

    public bool SetAnzahlGaeste(int anzahl)
    {
        if (anzahl < 0)
        {
            return false;
        }

        if (anzahl > maxGaeste)
        {
            return false;
        }

        anzahlGaeste = anzahl;
        return true;
    }

    public int GetMaxGaeste()
    {
        return maxGaeste;
    }

    public bool SetMaxGaeste(int max)
    {
        if (max < 0)
        {
            return false;
        }

        maxGaeste = max;
        return true;
    }

    public bool GetBelegt()
    {
        return anzahlGaeste > 0;
    }

    public string GetGastName()
    {
        return gastName;
    }

    public bool SetGastName(string gastName)
    {
        if (gastName == "")
        {
            return false;
        }

        this.gastName = gastName;
        return true;
    }
}