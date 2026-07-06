public class Auto
{
    public Auto(string marke, string modell, int baujahr)
    {
        this.Marke = marke;
        this.Modell = modell;
        this.Baujahr = baujahr;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Auto der Marke {marke}, Modell: {modell}, Baujahr: {baujahr}");
    }

    private string marke;

    public string Marke
    {
        get
        {
            return marke;
        }
        set
        {
            string[] marken = ["BMW", "Opel", "Trabant"];

            if(!marken.Contains(value))
            {
                throw new ArgumentException($"Marke {value} ist nicht zulässig");
            }
            
            marke = value;

            if (value == "BMW")
            {
                modell = "3er";
            }
            else if (value == "Opel")
            {
                modell = "Corsa";
            }
            else
            {
                modell = "P50";
            }
        }
    }

    private string modell;

    public string Modell
    {
        get
        {
            return modell;
        }
        set
        {
            if (marke == "BMW")
            {
                string[] modelle = ["3er", "5er", "7er"];

                if (!modelle.Contains(value))
                {
                    throw new ArgumentException($"Modell {value} ist bei Marke {marke} nicht erlaubt");
                }
            }
            else if (marke == "Opel")
            {
                string[] modelle = ["Corsa", "Astra", "Adam"];

                if (!modelle.Contains(value))
                {
                    throw new ArgumentException($"Modell {value} ist bei Marke {marke} nicht erlaubt");
                }
            }
            else
            {
                string[] modelle = ["P 50", "P 60", "P 601", "1.1"];

                if (!modelle.Contains(value))
                {
                    throw new ArgumentException($"Modell {value} ist bei Marke {marke} nicht erlaubt");
                }
            }
            
            modell = value;
        }
    }

    private int baujahr;

    public int Baujahr
    {
        get
        {
            return baujahr;
        }
        set
        {
            if (value < 1880)
            {
                throw new ArgumentException("Baujahr darf nicht kleiner als 1880 sein");
            }

            this.baujahr = value;
        }
    }

}