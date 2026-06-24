public class Hotelzimmer
{
    public string Zimmernummer;
    public int AnzahlGaeste;
    public int MaxGaeste;
    public bool Belegt;
    public string GastName;

    public Hotelzimmer(string zimmernummer)
    {
        Zimmernummer = zimmernummer;
    }
}