using System.Diagnostics.Contracts;

public abstract class Fahrzeug
{
    public abstract void Fahren();
}

public class LKW : Fahrzeug
{
    public override void Fahren()
    {
        Console.WriteLine("Der LKW fährt");
    }

    public int MaximaleBeladung { get; private set;}

    public LKW(int maximaleBeladung)
    {
        MaximaleBeladung = maximaleBeladung;
    }

    private int beladung;

    public int Beladung
    {
        get
        {
            return beladung;
        }
        set
        {
            if (value < 0 || value > MaximaleBeladung)
            {
                throw new ArgumentException("Beladung ist nicht im gültigen Bereich");
            }

            beladung = value;
        }
    }
}

public class Auto : Fahrzeug
{
    public Auto(string marke, string modell, int baujahr)
    {
        this.Marke = marke;
        this.Modell = modell;
        this.Baujahr = baujahr;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Auto der Marke {marke}, Modell: {modell}, Baujahr: {baujahr}");
    }

    public override void Fahren()
    {
        Console.WriteLine("Das Auto fährt.");
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

public class Cabrio : Auto
{
    public bool IsVerdeckOffen { get; set; }

    public Cabrio(string marke, string modell, int baujahr)
        : base(marke, modell, baujahr)
    {
        
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Cabrio von der Marke {Marke}, Modell {Modell}, Baujahr {Baujahr}");

        if (IsVerdeckOffen)
        {
            Console.WriteLine($"Verdeck ist offen");
        }
        else
        {
            Console.WriteLine($"Verdeck ist zu");
        }
        
        // // Alternative 1
        // var verdeck = IsVerdeckOffen ? "Verdeck ist offen" : "Verdeck ist zu";
        // Console.WriteLine(verdeck);
        
        // // Alternative 2
        // Console.WriteLine($"Verdeck ist {(IsVerdeckOffen ? "offen" : "zu")}");
    }
}