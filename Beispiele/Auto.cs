public class Auto
{
    private string marke;
    private string modell;
    private int baujahr;

    public void DisplayInfo()
    {
        Console.WriteLine($"Auto der Marke {marke}, Modell: {modell}, Baujahr: {baujahr}");
    }

    public bool SetMarke(string marke)
    {
        this.marke = marke;
        return true;
    }

    public string GetMarke()
    {
        return this.marke;
    }

    public bool SetModell(string modell)
    {
        this.modell = modell;
        return true;
    }

    public string GetModell()
    {
        return modell;
    }

    public bool SetBaujahr(int baujahr)
    {
        if (baujahr < 1880)
        {
            return false;
        }

        this.baujahr = baujahr;
        return true;
    }
}