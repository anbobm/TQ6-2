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
        // Teil1_Aufgabe4_20260701_Konstruktor();
        // Teil1_Aufgabe5_20260701_SinglePageApp();
        // Teil1_Aufgabe6_20260701_Abstract();
        // Teil1_Aufgabe7_20260701_Api();
        // Teil1_Aufgabe8_20260701_Onlineshop();
        Teil1_Aufgabe9_20260701_ToString();
    }




private static void Teil1_Aufgabe9_20260701_ToString()
{
    var projekt1 = new Webprojekt("Portfolio", "JavaScript", 2024);
    var projekt2 = new Webprojekt("Shop", "C#", 2023);

    projekt1.ZeigeInfo();
    projekt2.ZeigeInfo();

    Console.WriteLine(projekt1.ToString());
}


private static void Teil1_Aufgabe8_20260701_Onlineshop()
{
    var shop1 = new Onlineshop();

    shop1.AnzahlProdukte = 25;
    shop1.Veroeffentlichen();

    shop1.AnzahlProdukte = -5;

    Console.WriteLine($"Anzahl Produkte: {shop1.AnzahlProdukte}");
}



private static void Teil1_Aufgabe7_20260701_Api()
{
    var api1 = new Api(1000);

    api1.AktuelleAnfragenProMinute = 750;
    api1.Veroeffentlichen();

    api1.AktuelleAnfragenProMinute = 1200;

    Console.WriteLine($"Aktuelle Anfragen pro Minute: {api1.AktuelleAnfragenProMinute}");
    Console.WriteLine($"Maximale Anfragen pro Minute: {api1.MaximaleAnfragenProMinute}");
}



private static void Teil1_Aufgabe6_20260701_Abstract()
{
    var projekt1 = new Webprojekt("Shop", "C#", 2024);
    var app1 = new SinglePageApp("Portfolio", "JavaScript", 2024);

    projekt1.Veroeffentlichen();
    app1.Veroeffentlichen();
}


private static void Teil1_Aufgabe5_20260701_SinglePageApp()
{
    var app1 = new SinglePageApp("Portfolio", "JavaScript", 2024);
    app1.IstResponsive = true;

    var app2 = new SinglePageApp("Dashboard", "C#", 2023);
    app2.IstResponsive = false;

    app1.ZeigeInfo();
    app2.ZeigeInfo();
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


public abstract class DigitalesProdukt
{
    public abstract void Veroeffentlichen();
}




public class Webprojekt : DigitalesProdukt
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

   public override string ToString()
{
    return $"{Titel} | {Sprache} | {Framework} | {Erstellungsjahr}";
}

public virtual void ZeigeInfo()
{
    Console.WriteLine(ToString());
}
public override void Veroeffentlichen()
{
    Console.WriteLine($"{Titel} wurde veroeffentlicht.");
}
}



public class SinglePageApp : Webprojekt
{
    public bool IstResponsive { get; set; }

    public SinglePageApp(string titel, string sprache, int erstellungsjahr)
        : base(titel, sprache, erstellungsjahr)
    {
    }

    public override void ZeigeInfo()
    {
        base.ZeigeInfo();

        if (IstResponsive)
        {
            Console.WriteLine("Die Anwendung ist responsive.");
        }
        else
        {
            Console.WriteLine("Die Anwendung ist nicht responsive.");
        }
    }
}



public class Api : DigitalesProdukt
{
    private int aktuelleAnfragenProMinute;

    public int AktuelleAnfragenProMinute
    {
        get { return aktuelleAnfragenProMinute; }
        set
        {
            if (value >= 0 && value <= MaximaleAnfragenProMinute)
            {
                aktuelleAnfragenProMinute = value;
            }
        }
    }

    public int MaximaleAnfragenProMinute { get; private set; }

    public Api(int maximaleAnfragenProMinute)
    {
        MaximaleAnfragenProMinute = maximaleAnfragenProMinute;
    }

    public override void Veroeffentlichen()
    {
        Console.WriteLine("Api wurde veroeffentlicht.");
    }
}






public class Onlineshop : DigitalesProdukt
{
    private int anzahlProdukte;

    public int AnzahlProdukte
    {
        get { return anzahlProdukte; }
        set
        {
            if (value >= 0)
            {
                anzahlProdukte = value;
            }
        }
    }

    public override void Veroeffentlichen()
    {
        Console.WriteLine("Onlineshop wurde veroeffentlicht.");
    }
}