using System;

class Program
{

private static void Teil1_Aufgabe4_20260701_Konstruktor()
{
    Webprojekt p1 = new Webprojekt("Portfolio", "JavaScript", 2023);
    Webprojekt p2 = new Webprojekt("Shop", "C#", 2024);
    Webprojekt p3 = new Webprojekt("Blog", "Python", 2020);

    p1.ZeigeInfo();
    p2.ZeigeInfo();
    p3.ZeigeInfo();
}


    static void Main(string[] args)
    {
        // Teil1_Aufgabe1_20260701_Klasse();
        // Teil1_Aufgabe2_20260701_Kapselung();
        // Teil1_Aufgabe3_20260701_Properties();
        Teil1_Aufgabe4_20260701_Konstruktor();

    }

    private static void Teil1_Aufgabe1_20260701_Klasse()
    {
        Webprojekt p1 = new Webprojekt();
        p1.SetTitel("Portfolio");
        p1.SetSprache("JavaScript");
        p1.SetErstellungsjahr(2023);

        Webprojekt p2 = new Webprojekt();
        p2.SetTitel("Shop");
        p2.SetSprache("C#");
        p2.SetErstellungsjahr(2024);

        p1.ZeigeInfo();
        p2.ZeigeInfo();
    }

    private static void Teil1_Aufgabe2_20260701_Kapselung()
    {
        Webprojekt p1 = new Webprojekt();
        p1.SetTitel("Shop");
        p1.SetSprache("C#");
        p1.SetErstellungsjahr(2023);

        Webprojekt p2 = new Webprojekt();
        p2.SetTitel("Blog");
        p2.SetSprache("Python");
        p2.SetErstellungsjahr(2020);

        p1.ZeigeInfo();
        p2.ZeigeInfo();
    }

    private static void Teil1_Aufgabe3_20260701_Properties()
    {
        Webprojekt p1 = new Webprojekt();
        p1.Titel = "Shop";
        p1.Sprache = "C#";
        p1.Erstellungsjahr = 2023;

        Webprojekt p2 = new Webprojekt();
        p2.Titel = "Blog";
        p2.Sprache = "Python";
        p2.Erstellungsjahr = 2020;

        p1.ZeigeInfo();
        p2.ZeigeInfo();
    }
}


public class Webprojekt
{


    private string titel = "";
    private string sprache = "";
    private string framework = "";
    private int erstellungsjahr;


 public Webprojekt()
    {
    }

    public Webprojekt(string titel, string sprache, int erstellungsjahr)
{
    Titel = titel;
    Sprache = sprache;
    Erstellungsjahr = erstellungsjahr;
}

    public string Titel
    {
        get { return titel; }
        set { titel = value; }
    }

    public string Sprache
    {
        get { return sprache; }
        set
        {
            if (value == "C#")
            {
                sprache = value;
                framework = "ASP.NET Core";
            }
            else if (value == "JavaScript")
            {
                sprache = value;
                framework = "React";
            }
            else if (value == "Python")
            {
                sprache = value;
                framework = "Django";
            }
            else
            {
                Console.WriteLine("Fehler: Ungueltige Sprache.");
            }
        }
    }

    public string Framework
    {
        get { return framework; }
    }

    public int Erstellungsjahr
    {
        get { return erstellungsjahr; }
        set
        {
            if (value >= 1991)
            {
                erstellungsjahr = value;
            }
            else
            {
                Console.WriteLine("Jahr muss >= 1991 sein!");
            }
        }
    }

    public string GetTitel()
    {
        return Titel;
    }

    public void SetTitel(string titel)
    {
        Titel = titel;
    }

    public string GetSprache()
    {
        return Sprache;
    }

    public void SetSprache(string sprache)
    {
        Sprache = sprache;
    }

    public int GetErstellungsjahr()
    {
        return Erstellungsjahr;
    }

    public void SetErstellungsjahr(int erstellungsjahr)
    {
        Erstellungsjahr = erstellungsjahr;
    }

    public void ZeigeInfo()
    {
        Console.WriteLine($"{Titel} | {Sprache} | {Framework} | {Erstellungsjahr}");
    }
}