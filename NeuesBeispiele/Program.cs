using System;
using System.Collections.Generic;

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
        // Teil1_Aufgabe9_20260701_ToString();
        // Teil1_Aufgabe9_20260701_ToString();
        // Teil1_Aufgabe10_20260701_Static();
        // Teil2_Aufgabe1_20260701_Benutzerkonto();
        //Teil2_Aufgabe2_20260701_Warenkorb();
        //Teil2_Aufgabe3_20260701_HttpAnfrage();
        // Teil2_Aufgabe4_20260701_Cookie();
        // Teil2_Aufgabe5_20260701_Session();
        //Teil2_Aufgabe6_20260701_Blogbeitrag();
        // Teil2_Aufgabe7_20260701_Newsletterabonnent();
        // Teil2_Aufgabe9_20260701_Passwortvalidator(); 
        Teil2_Aufgabe10_20260701_Seitenaufrufzaehler();

}


private static void Teil2_Aufgabe10_20260701_Seitenaufrufzaehler()
{
    var zaehler1 = new Seitenaufrufzaehler();

    zaehler1.AufrufRegistrieren();
    zaehler1.AufrufRegistrieren();
    zaehler1.AufrufRegistrieren();

    Console.WriteLine($"Aufrufe: {zaehler1.GetAufrufe()}");

    zaehler1.Zuruecksetzen();

    Console.WriteLine($"Aufrufe nach Reset: {zaehler1.GetAufrufe()}");
}




private static void Teil2_Aufgabe9_20260701_Passwortvalidator()
{
    var validator1 = new Passwortvalidator();

    Console.WriteLine($"abc gueltig: {validator1.IstGueltig("abc")}");
    Console.WriteLine($"passwort123 gueltig: {validator1.IstGueltig("passwort123")}");
    Console.WriteLine($"Passwort123 gueltig: {validator1.IstGueltig("Passwort123")}");

    validator1.SetMindestlaenge(5);

    Console.WriteLine($"Abc1d gueltig: {validator1.IstGueltig("Abc1d")}");
}


private static void Teil2_Aufgabe7_20260701_Newsletterabonnent()
{
    var abonnent1 = new Newsletterabonnent("nataliya@example.com");

    abonnent1.Abbestellen();
    abonnent1.Abonnieren();

    abonnent1.EmailAendern("neue.adresse@example.com");
    abonnent1.EmailAendern("ungueltige-email");

    Console.WriteLine("Newsletterabonnent wurde getestet.");
}



private static void Teil2_Aufgabe6_20260701_Blogbeitrag()
{
    var beitrag1 = new Blogbeitrag("C# lernen", "Heute lernen wir Klassen und Objekte.");

    beitrag1.KommentarHinzufuegen();

    Console.WriteLine(beitrag1.GetInfo());

    beitrag1.Veroeffentlichen();
    beitrag1.KommentarHinzufuegen();
    beitrag1.KommentarHinzufuegen();

    Console.WriteLine(beitrag1.GetInfo());
}




private static void Teil2_Aufgabe5_20260701_Session()
{
    var session1 = new Session("ABC123");

    session1.AktivitaetAktualisieren(10);

    Console.WriteLine($"Abgelaufen bei Minute 15 und Timeout 10: {session1.IstAbgelaufen(15, 10)}");
    Console.WriteLine($"Abgelaufen bei Minute 25 und Timeout 10: {session1.IstAbgelaufen(25, 10)}");

    session1.AktivitaetAktualisieren(25);

    Console.WriteLine($"Abgelaufen nach neuer Aktivitaet bei Minute 30: {session1.IstAbgelaufen(30, 10)}");
}





private static void Teil2_Aufgabe4_20260701_Cookie()
{
    var cookie1 = new Cookie("session", "abc123", 7);

    Console.WriteLine($"Abgelaufen nach 3 Tagen: {cookie1.IstAbgelaufen(3)}");
    Console.WriteLine($"Abgelaufen nach 8 Tagen: {cookie1.IstAbgelaufen(8)}");

    cookie1.Verlaengern(5);
    cookie1.SetWert("xyz789");

    Console.WriteLine($"Abgelaufen nach 8 Tagen nach Verlaengerung: {cookie1.IstAbgelaufen(8)}");
}



private static void Teil2_Aufgabe3_20260701_HttpAnfrage()
{
    var anfrage1 = new HttpAnfrage("GET", "https://example.com/api/products");

    anfrage1.SendenSimulieren(200);

    Console.WriteLine(anfrage1.GetInfo());
    Console.WriteLine($"Erfolgreich: {anfrage1.IstErfolgreich()}");

    anfrage1.SetMethode("POST");
    anfrage1.SendenSimulieren(404);

    Console.WriteLine(anfrage1.GetInfo());
    Console.WriteLine($"Erfolgreich: {anfrage1.IstErfolgreich()}");
}



private static void Teil2_Aufgabe1_20260701_Benutzerkonto()
{
    var konto1 = new Benutzerkonto("nataliya", "geheim123");

    konto1.EmailFestlegen("nataliya@example.com");

    Console.WriteLine($"Login falsch: {konto1.Login("falsch")}");
    Console.WriteLine($"Eingeloggt: {konto1.Eingeloggt()}");

    Console.WriteLine($"Login richtig: {konto1.Login("geheim123")}");
    Console.WriteLine($"Eingeloggt: {konto1.Eingeloggt()}");

    konto1.PasswortAendern("geheim123", "neuesPasswort");

    konto1.Logout();
    Console.WriteLine($"Eingeloggt nach Logout: {konto1.Eingeloggt()}");

    Console.WriteLine($"Login neues Passwort: {konto1.Login("neuesPasswort")}");
}


private static void Teil2_Aufgabe2_20260701_Warenkorb()
{
    var warenkorb1 = new Warenkorb();

    warenkorb1.ArtikelHinzufuegen("Laptop", 899.99m, 1);
    warenkorb1.ArtikelHinzufuegen("Maus", 19.99m, 2);
    warenkorb1.ArtikelHinzufuegen("Tastatur", 49.99m, 1);

    Console.WriteLine($"Anzahl Artikel: {warenkorb1.AnzahlArtikel()}");
    Console.WriteLine($"Gesamtsumme: {warenkorb1.Gesamtsumme()} EUR");

    warenkorb1.ArtikelEntfernen("Maus");

    Console.WriteLine($"Anzahl Artikel nach Entfernen: {warenkorb1.AnzahlArtikel()}");
    Console.WriteLine($"Gesamtsumme nach Entfernen: {warenkorb1.Gesamtsumme()} EUR");
}


private static void Teil1_Aufgabe10_20260701_Static()
{
    var projekt1 = new Webprojekt("Portfolio", "JavaScript", 2024);
    var app1 = new SinglePageApp("Dashboard", "C#", 2023);
    var api1 = new Api(1000);
    var shop1 = new Onlineshop();

    Console.WriteLine($"Gesamtanzahl: {DigitalesProdukt.GetGesamtanzahl()}");
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
    public static int AnzahlErstellterProdukte { get; private set; }

    protected DigitalesProdukt()
    {
        AnzahlErstellterProdukte++;
    }

    public static int GetGesamtanzahl()
    {
        return AnzahlErstellterProdukte;
    }

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



public class Benutzerkonto
{
    private string benutzername;
    private string email = "";
    private string passwort;
    private bool eingeloggt = false;

    public Benutzerkonto(string benutzername, string passwort)
    {
        this.benutzername = benutzername;
        this.passwort = passwort;
    }

    public void EmailFestlegen(string email)
    {
        if (email.Contains("@") && email.Contains("."))
        {
            this.email = email;
        }
        else
        {
            Console.WriteLine("Fehler: Ungueltige Email-Adresse.");
        }
    }

    public bool Login(string passwort)
    {
        if (this.passwort == passwort)
        {
            eingeloggt = true;
        }

        return eingeloggt;
    }

    public void Logout()
    {
        eingeloggt = false;
    }

    public void PasswortAendern(string altesPw, string neuesPw)
    {
        if (altesPw != passwort)
        {
            Console.WriteLine("Fehler: Altes Passwort stimmt nicht ueberein.");
            return;
        }

        if (neuesPw.Length < 8)
        {
            Console.WriteLine("Fehler: Neues Passwort muss mindestens 8 Zeichen lang sein.");
            return;
        }

        passwort = neuesPw;
    }

    public bool Eingeloggt()
    {
        return eingeloggt;
    }
}

public class Warenkorb
{
    private class Artikel
    {
        public string Name = "";
        public decimal Preis;
        public int Menge;
    }

    private List<Artikel> artikel = new List<Artikel>();

    public void ArtikelHinzufuegen(string name, decimal preis, int menge)
    {
        if (preis <= 0 || menge <= 0)
        {
            Console.WriteLine("Fehler: Preis und Menge muessen positiv sein.");
            return;
        }

        artikel.Add(new Artikel { Name = name, Preis = preis, Menge = menge });
    }

    public void ArtikelEntfernen(string name)
    {
        artikel.RemoveAll(a => a.Name == name);
    }

    public decimal Gesamtsumme()
    {
        decimal summe = 0;

        foreach (var a in artikel)
        {
            summe += a.Preis * a.Menge;
        }

        return summe;
    }

    public int AnzahlArtikel()
    {
        int anzahl = 0;

        foreach (var a in artikel)
        {
            anzahl += a.Menge;
        }

        return anzahl;
    }
}


public class HttpAnfrage
{
    private static readonly string[] ErlaubteMethoden = { "GET", "POST", "PUT", "DELETE" };

    private string methode = "";
    private string url;
    private int statuscode = 0;

    public HttpAnfrage(string methode, string url)
    {
        SetMethode(methode);
        this.url = url;
    }

    public void SetMethode(string methode)
    {
        if (Array.IndexOf(ErlaubteMethoden, methode) >= 0)
        {
            this.methode = methode;
        }
        else
        {
            Console.WriteLine("Fehler: Ungueltige HTTP-Methode.");
        }
    }

    public void SendenSimulieren(int statuscode)
    {
        this.statuscode = statuscode;
    }

    public bool IstErfolgreich()
    {
        return statuscode >= 200 && statuscode <= 299;
    }

    public string GetInfo()
    {
        return $"{methode} {url} -> Status {statuscode}";
    }
}


public class Cookie
{
    private string name;
    private string wert;
    private int gueltigkeitsdauerTage;

    public Cookie(string name, string wert, int gueltigkeitsdauerTage)
    {
        this.name = name;
        this.wert = wert;
        this.gueltigkeitsdauerTage = gueltigkeitsdauerTage;
    }

    public bool IstAbgelaufen(int vergangeneTage)
    {
        return vergangeneTage > gueltigkeitsdauerTage;
    }

    public void Verlaengern(int tage)
    {
        if (tage <= 0)
        {
            Console.WriteLine("Fehler: Nur positive Werte zulaessig.");
            return;
        }

        gueltigkeitsdauerTage += tage;
    }

    public void SetWert(string neuerWert)
    {
        wert = neuerWert;
    }

}


public class Session
{
    private string sessionId;
    private int letzteAktivitaetMinute = 0;

    public Session(string sessionId)
    {
        this.sessionId = sessionId;
    }

    public void AktivitaetAktualisieren(int aktuelleMinute)
    {
        letzteAktivitaetMinute = aktuelleMinute;
    }

    public bool IstAbgelaufen(int aktuelleMinute, int timeoutMinuten)
    {
        return (aktuelleMinute - letzteAktivitaetMinute) > timeoutMinuten;
    }
}



public class Blogbeitrag
{
    private string titel;
    private string inhalt;
    private bool veroeffentlicht = false;
    private int kommentarAnzahl = 0;

    public Blogbeitrag(string titel, string inhalt)
    {
        this.titel = titel;
        this.inhalt = inhalt;
    }

    public void Veroeffentlichen()
    {
        veroeffentlicht = true;
    }

    public void KommentarHinzufuegen()
    {
        if (veroeffentlicht)
        {
            kommentarAnzahl++;
        }
        else
        {
            Console.WriteLine("Fehler: Beitrag ist noch nicht veroeffentlicht.");
        }
    }

    public string GetInfo()
    {
        return $"{titel} (veroeffentlicht: {veroeffentlicht}, Kommentare: {kommentarAnzahl})";
    }
}



public class Newsletterabonnent
{
    private string email;
    private bool aktiv = true;

    public Newsletterabonnent(string email)
    {
        if (IstGueltig(email))
        {
            this.email = email;
        }
        else
        {
            throw new ArgumentException("Ungueltige Email-Adresse.");
        }
    }

    private bool IstGueltig(string email)
    {
        int at = email.IndexOf('@');
        return at > 0 && email.IndexOf('.', at) > at;
    }

    public void Abbestellen()
    {
        aktiv = false;
    }

    public void Abonnieren()
    {
        aktiv = true;
    }

    public void EmailAendern(string neueEmail)
    {
        if (IstGueltig(neueEmail))
        {
            email = neueEmail;
        }
        else
        {
            Console.WriteLine("Fehler: Ungueltige Email-Adresse.");
        }
    }
}


public class Passwortvalidator
{
    private int mindestlaenge = 8;

    public void SetMindestlaenge(int laenge)
    {
        if (laenge >= 4)
        {
            mindestlaenge = laenge;
        }
    }

    public bool IstGueltig(string passwort)
    {
        if (passwort.Length < mindestlaenge)
        {
            return false;
        }

        bool hatZiffer = false;
        bool hatGrossbuchstabe = false;

        foreach (char zeichen in passwort)
        {
            if (char.IsDigit(zeichen))
            {
                hatZiffer = true;
            }

            if (char.IsUpper(zeichen))
            {
                hatGrossbuchstabe = true;
            }
        }

        return hatZiffer && hatGrossbuchstabe;
    }
}



public class Seitenaufrufzaehler
{
    private int aufrufe;

    public void AufrufRegistrieren()
    {
        aufrufe++;
    }

    public void Zuruecksetzen()
    {
        aufrufe = 0;
    }

    public int GetAufrufe()
    {
        return aufrufe;
    }
}





