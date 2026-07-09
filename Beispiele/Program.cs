using Bibliothek;

internal partial class Program
{
    private static void Main(string[] args)
    {
        // HelloWorld();
        // Variablen();
        // EinUndAusgabe();
        // TypUmwandlungen();
        // ArithmetischeOperatoren();
        // VergleichsOperatoren();
        // LogischeOperatoren();
        // ErsteAufgabe();
        // Verzweigungen();
        // Schleifen();
        // SchleifenAufgabe1();
        // SchleifenAufgabe2();
        // Listen();
        // ListenAufgabe1();
        // ListenAufgabe2();
        // Linq();
        // LinqSort();
        // Dictionaries();
        // Tupel();
        // ArrayAufgabe1();
        // ArrayAufgabe2();
        // DictionaryAufgabe1();
        // DictionaryAufgabe2();
        // DictionaryAufgabe2Zusatz();
        // DictionaryAufgabe2Zusatzb();
        // DictionaryAufgabe2_1();
        // DictionaryAufgabe2_2();
        // DictionaryAufgabe2_3();
        // DictionaryAufgabe2_4();
        // Exceptions();
        // ExceptionsAufgabe1();
        // ExceptionsAufgabe2();
        // ExceptionsAufgabe3();
        // ExceptionsAufgabe4();
        // OOPAufgabe1();
        // OOPAufgabe4();
        // OOPAufgabe2_1();
        // OOPAufgabe2_2();
        // StatischeAttribute();
        // StatischeAttribute_Aufgabe2();
        // StatischeAttribute_Aufgabe3();
        // AufgabenTeil1_1();
        // PrivaterKonstruktorBeispiel();
        // AufgabenTeil2_1();
        // AufgabenTeil2_2();
        // AufgabenTeil2_3();
        // AufgabenTeil2_4();
        // AufgabenTeil2_5();
        // AufgabeIsbn();
        AufgabeBibiliothek2();
    }

    private static void AufgabeBibiliothek2()
    {
        var bibliothek = new Bibliothek.Bibliothek();

        var benutzer1 = new Bibliothek.Benutzer("Max Mustermann");

        var buch1 = new Bibliothek.Buch("Das Parfüm", 280, "Patrick Süskind");
        var buch2 = new Bibliothek.Buch("Harry Potter der Stein der Weisen", 342, "Lord Voldemort");

        var dvd1 = new Dvd("Harry Potter der Stein der Weisen", 90, "Chris Columbus");
        var dvd2 = new Dvd("Herr der Ringe: Rückkehr des Königs", 180, "Peter Jackson");
        dvd2.Ausleihen(benutzer1);

        bibliothek.Hinzufuegen(buch1);
        bibliothek.Hinzufuegen(buch2);
        bibliothek.Hinzufuegen(dvd1);
        bibliothek.Hinzufuegen(dvd2);

        MedienAusgeben(bibliothek.Medien);
        MedienAusgeben(bibliothek.AusgelieheneMedien);

        dvd2.Zurueckgeben();

        MedienAusgeben(bibliothek.Medien);
        MedienAusgeben(bibliothek.AusgelieheneMedien);
    }

    private static void MedienAusgeben(List<Medium> medien)
    {
        if (medien.Count == 0)
        {
            Console.WriteLine("Keine Medien gefunden");
        }
        foreach(var medium in medien)
        {
            Console.Write($"{medium.Titel}: ");

            if (medium.IstAusgeliehen)
            {
                Console.WriteLine($"ausgeliehen von {medium.AusgeliehenVon.Name}");
            }
            else
            {
                Console.WriteLine("nicht ausgeliehen");
            }
        }
    }

    private static void AufgabeIsbn()
    {
        Dictionary<string,bool> isbns = new Dictionary<string, bool>
        {
            {"9780306406157", true}, // gültig
            {"9783423264303", true}, // gültig
            {"9781784878979", true}, // gültig
            {"97817-84878-979", true}, // gültig aber mit Trennstrichen
            {"9781784878978", false}, // ungültig
            {"97803064061570", false}, // ungültig (zu lang), könnte aber für manche gültig aussehen
            {"9781784871", false} // ungültig (zu kurz), könnte aber für manche gültig aussehen
        };

        foreach (var kvp in isbns)
        {
            var isbn = kvp.Key;
            var valid = kvp.Value;
            var validString = valid ? "gültig" : "ungültig";

            if (Isbn.IsValid(isbn) == valid)
            {
                Console.WriteLine($"{isbn} erfolgreich als {validString} erkannt!");
            }
            else
            {
                Console.WriteLine($"FEHLER: {isbn} nicht als {validString} erkannt!");
                
            }
        }
    }

    private static void AufgabenTeil2_5()
    {
        var mitarbeiter = new Mitarbeiter("Paul", 4500);
        Console.WriteLine($"{mitarbeiter.Name}: Gehalt: {mitarbeiter.GetGehalt()}");

        mitarbeiter.GehaltErhoehen(10);
        Console.WriteLine($"{mitarbeiter.Name}: Gehalt: {mitarbeiter.GetGehalt()}");

        var manager = new Manager("Max", 10000, 50000);
        Console.WriteLine($"{manager.Name}: Gehalt: {manager.GetGehalt()}");

        manager.GehaltErhoehen(10);
        Console.WriteLine($"{manager.Name}: Gehalt: {manager.GetGehalt()}");
    }

    private static void AufgabenTeil2_4()
    {
        var sensor = new Temperatursensor();
        Console.WriteLine($"{sensor.TemperaturCelsius} °C, {sensor.TemperaturFahrenheit} °F");

        sensor.Erhoehen(100);
        Console.WriteLine($"{sensor.TemperaturCelsius} °C, {sensor.TemperaturFahrenheit} °F");

        sensor.Senken(373.15m);
        Console.WriteLine($"{sensor.TemperaturCelsius} °C, {sensor.TemperaturFahrenheit} °F");

        sensor.Senken(0.0001m);
        Console.WriteLine($"{sensor.TemperaturCelsius} °C, {sensor.TemperaturFahrenheit} °F");
    }

    private static void AufgabenTeil2_3()
    {
        var benutzer = new Benutzer("admin", "p4ssw0rd!");

        benutzer.Login("p4ssw0rd!");
        Console.WriteLine($"Eingeloggt: {benutzer.IstEingeloggt}");

        benutzer.Logout();
        Console.WriteLine($"Eingeloggt: {benutzer.IstEingeloggt}");

        if (benutzer.PasswortÄndern("p4ssw0rd!", "kurz"))
        {
            Console.WriteLine("Password erfolgreich geändert");
        }
        else
        {
            Console.WriteLine("Password konnte nicht geändert werden");
        }
    }

    private static void AufgabenTeil2_2()
    {
        var rechteck = new Rechteck(20, 30);

        Console.WriteLine($"Breite: {rechteck.Breite}, Hoehe: {rechteck.Hoehe}");
        Console.WriteLine($"Fläche: {rechteck.Flaeche}, Umfang: {rechteck.Umfang}");

        // Exception
        rechteck.Hoehe = -30;
    }

    private static void AufgabenTeil2_1()
    {
        var produkt = new Produkt("Goldener Apfel", 100m);

        Console.WriteLine(produkt.GetInfo());

        produkt.Nachbestellen(50);

        Console.WriteLine(produkt.GetInfo());

        produkt.Nachbestellen(50);

        Console.WriteLine(produkt.GetInfo());

        produkt.Verkaufen(100);

        Console.WriteLine(produkt.GetInfo());

        // Müsste Exception werfen
        produkt.Nachbestellen(1);
    }

    private static void PrivaterKonstruktorBeispiel()
    {
        var person = Person.Create(null);

        Console.WriteLine(person.Name);
    }

    private static void AufgabenTeil1_1()
    {
        var auto1 = new Auto("Opel", "Astra", 1981);
        var auto2 = new Auto("Trabant", "P 601", 1985);
        var auto3 = new Auto("BMW", "3er", 1990);
        Auto auto4 = new Cabrio("Opel", "Adam", 2010);
        var lkw1 = new LKW(40000);

        auto1.DisplayInfo();
        auto2.DisplayInfo();
        auto3.DisplayInfo();

        auto4.DisplayInfo();

        lkw1.Fahren();
        lkw1.Beladung = 1000;
        lkw1.Beladung = 40001;
    }

    private static void StatischeAttribute_Aufgabe3()
    {
        var konto1 = new Bankkonto("Sabine", "DE32 5923 4661 5717 5712 32", 1000.0m);
        var konto2 = new Bankkonto("Petra", "DE17 1128 3712 3128 7931 09", 100000.0m);

        Bankkonto.Zinssatz = 0.1m;
        konto1.ZinsenAuszahlen();

        konto1.Info();
        konto2.Info();

        Bankkonto.Zinssatz = 0.2m;
        konto1.ZinsenAuszahlen();
        konto2.ZinsenAuszahlen();

        konto1.Info();
        konto2.Info();
    }

    public class Bankkonto
    {
        public string Inhaber { get; }

        public string Kontonummer { get; }

        public decimal Kontostand { get; private set; }

        public static decimal Zinssatz { get; set; }

        public Bankkonto(string inhaber, string kontonummer, decimal kontostand)
        {
            Inhaber = inhaber;
            Kontonummer = kontonummer;
            Kontostand = kontostand;
        }

        public void ZinsenAuszahlen()
        {
            Kontostand += Kontostand * Zinssatz;
        }

        public void Info()
        {
            Console.WriteLine($"{Inhaber} {Kontonummer} {Kontostand}");
        }
    }

    private static void StatischeAttribute_Aufgabe2()
    {
        var bestellung1 = new Bestellung("Tunahan");

        bestellung1.ArtikelHinzufügen("Klimaanlage", 1499.90m);
        bestellung1.ArtikelHinzufügen("Eismaschine", 49.99m);
        bestellung1.ArtikelHinzufügen("gekühlter Apfel", 0.79m);

        var bestellung2 = new Bestellung("Tunahan");

        bestellung2.ArtikelHinzufügen("Klimaanlage", 1499.90m);
        bestellung2.ArtikelHinzufügen("Klimaanlage", 1499.90m);

        BestellungAusgeben(bestellung1);
        BestellungAusgeben(bestellung2);
    }

    private static void StatischeAttribute()
    {
        var b1 = new Beispiel();
        var b2 = new Beispiel();

        b1.Info();
        b2.Info();

        b1.SetBar(1);

        b1.Info();
        b2.Info();
    }

    public class Beispiel
    {
        private static int bar;

        public void SetBar(int value)
        {
            bar = value;
        }

        public void Info()
        {
            Console.WriteLine($"bar ist {bar}");
        }
    }

    private static void OOPAufgabe2_2()
    {
        var hund = new Hund("Max", "Schäferhund");

        hund.SagHallo();
    }

    private static void OOPAufgabe2_1()
    {
        var buch1 = new Buch("Der Hobbit", "J.R.R. Tolkien");
        var buch2 = new Buch("Der Hobbit");

        Console.WriteLine($"{buch1.Autor} - {buch1.Titel}");
        Console.WriteLine($"{buch2.Autor} - {buch2.Titel}");
    }

    private static void OOPAufgabe4()
    {
        var bestellung = new Bestellung("Tunahan");

        BestellungAusgeben(bestellung);

        bestellung.ArtikelHinzufügen("Klimaanlage", 1499.90m);
        bestellung.ArtikelHinzufügen("Eismaschine", 49.99m);

        BestellungAusgeben(bestellung);

        bestellung.ArtikelHinzufügen("gekühlter Apfel", 0.79m);

        BestellungAusgeben(bestellung);

        // Artikel-Liste ist nur Kopie, ändern der Liste wirkt sich nicht
        // auf Bestellung aus

        bestellung.Artikel.Add(("Duschgel", 1.99m));

        BestellungAusgeben(bestellung);
    }

    private static void BestellungAusgeben(Bestellung bestellung)
    {
        Console.WriteLine($"Bestellung für: {bestellung.Kunde}, Bestellungsnummer: {bestellung.Bestellungsnummer}");
        Console.WriteLine($"Anzahl Artikel: {bestellung.AnzahlArtikel}");
        Console.WriteLine($"Gesamtpreis: {bestellung.Gesamtpreis} €");

        if (bestellung.AnzahlArtikel > 0)
        {
            Console.WriteLine("Artikel:");

            foreach (var artikel in bestellung.Artikel)
            {
                Console.WriteLine($"    {artikel.Name}: {artikel.Stückpreis} €");
            }
        }
    }

    private static void OOPAufgabe1()
    {
        var zimmer1 = new Hotelzimmer("001");
        // Setzen der Attribute direkt, weil public
        zimmer1.MaxGaeste = 4;
        zimmer1.AnzahlGaeste = 3;
        zimmer1.GastName = "Tunahan";
        Console.WriteLine(zimmer1.Belegt ? "belegt" : "nicht belegt");

        // Setzen der Attribute auf unsinnige Werte
        // Außerdem object initializer syntax
        var zimmer2 = new Hotelzimmer("002");

        try
        {
            zimmer2.MaxGaeste = -10;
        }
        catch(ArgumentException e)
        {
            Console.WriteLine($"Fehler aufgetreten: {e.Message}");
        }

        try
        {
            zimmer2.AnzahlGaeste = -4;
        }
        catch(ArgumentException e)
        {
            Console.WriteLine($"Fehler aufgetreten: {e.Message}");
        }

        try
        {
            zimmer2.GastName = "";
        }
        catch(ArgumentException e)
        {
            Console.WriteLine($"Fehler aufgetreten: {e.Message}");
        }

        Console.WriteLine(zimmer2.Belegt ? "belegt" : "nicht belegt");
    }

    private static void ExceptionsAufgabe4()
    {
        
        try
        {
            Console.WriteLine(Durchschnitt4(null));
        }
        catch(ArgumentNullException)
        {
            Console.WriteLine("Die Liste existiert nicht.");
        }
        catch(ArgumentException)
        {
            Console.WriteLine("Durchschnitt konnte nicht berechnet werden, da Liste leer.");
        }
    }

    private static double Durchschnitt4(List<int> liste)
    {
        if (liste == null)
        {
            throw new ArgumentNullException();
        }

        if (liste.Count == 0)
        {
            throw new ArgumentException();
        }

        int summe = 0;
        foreach (var element in liste)
        {
            summe += element;
        }

        return summe / liste.Count;

        // Alternative mit InvalidOperationException
        // return liste.Average();
    }

    private static void ExceptionsAufgabe3()
    {
        var studenten = new Dictionary<string, Dictionary<string, int>>
        {
            { "Alice", new Dictionary<string, int> { { "Mathematik", 95 }, { "Englisch", 88 }, { "Geschichte", 90 } } },
            { "Bob", new Dictionary<string, int> { { "Mathematik", 75 }, { "Englisch", 81 }, { "Geschichte", 78 } } },
            { "Charlie", new Dictionary<string, int> { { "Mathematik", 88 }, { "Englisch", 91 }, { "Geschichte", 85 } } },
            { "Diana", new Dictionary<string, int> { { "Mathematik", 93 }, { "Englisch", 89 }, { "Geschichte", 94 } } }
        };

        Console.WriteLine("Folgende Studenten sind gespeichert:");
        foreach (var student in studenten)
        {
            Console.WriteLine(student.Key);
        }

        Console.Write("\nGib einen Namen ein für eine Detailansicht: ");
        var eingabe = Console.ReadLine()!;

        try
        {
            foreach (var fach in studenten[eingabe])
            {
                Console.WriteLine($"{fach.Key}: {fach.Value}");
            }
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Diesen Studenten gibt es nicht");
        }

        // // Ohne Exceptions:
        // if(studenten.ContainsKey(eingabe))
        // {
        //     foreach (var fach in studenten[eingabe])
        //     {
        //         Console.WriteLine($"{fach.Key}: {fach.Value}");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Diesen Studenten gibt es nicht");
        // }
    }

    private static void ExceptionsAufgabe2()
    {
        try
        {
            Console.Write("Gib Zahl! ");
            var zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gib noch eine Zahl! ");
            var zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{zahl1} / {zahl2} = {zahl1 / zahl2} mit Rest {zahl1 % zahl2}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Die eingegebene Zahl ist zu groß/klein.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Eingabe war keine Zahl");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Fehler: Division durch 0");
        }
    }

    private static void ExceptionsAufgabe1()
    {
        try
        {
            Console.WriteLine(Durchschnitt([]));
        }
        catch(ArgumentException)
        {
            Console.WriteLine("Durchschnitt konnte nicht berechnet werden, da Liste leer.");
        }
    }

    private static double Durchschnitt(List<int> liste)
    {
        if (liste.Count == 0)
        {
            throw new ArgumentException();
        }

        int summe = 0;
        foreach (var element in liste)
        {
            summe += element;
        }

        return summe / liste.Count;

        // Alternative mit InvalidOperationException
        // return liste.Average();
    }

    private static void Exceptions()
    {
        var eingabe = Console.ReadLine();

        try
        {
            Convert.ToInt32(eingabe);
        }
        catch(FormatException)
        {
            Console.WriteLine("Die eingegebene Zahl war nicht in einem gültigen Format.");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Der Wert passt nicht in ein int.");
        }
    }

    private static void DictionaryAufgabe2_4()
    {
        var noten = new Dictionary<string, Dictionary<string, int>>
        {
            { "Alice", new Dictionary<string, int> { { "Mathematik", 95 }, { "Englisch", 88 }, { "Geschichte", 90 } } },
            { "Bob", new Dictionary<string, int> { { "Mathematik", 75 }, { "Englisch", 81 }, { "Geschichte", 78 } } },
            { "Charlie", new Dictionary<string, int> { { "Mathematik", 88 }, { "Englisch", 91 }, { "Geschichte", 85 } } },
            { "Diana", new Dictionary<string, int> { { "Mathematik", 93 }, { "Englisch", 89 }, { "Geschichte", 94 } } }
        };
        
        Console.WriteLine(BesterStudent(noten));
    }

    private static (string Name, double Durchschnitt) BesterStudent(Dictionary<string, Dictionary<string, int>> noten)
    {
        double besterDurchschnitt = -1;
        string besterStudent = "";

        foreach (var student in noten)
        {
            var studentName = student.Key;
            var fächer = student.Value;

            // var summe = 0;
            // foreach (var fach in fächer)
            // {
            //     summe = summe + fach.Value;
            // }
            // var durchschnitt = (double) summe / fächer.Count;

            var durchschnitt = fächer.Values.Average();

            if (durchschnitt > besterDurchschnitt)
            {
                besterDurchschnitt = durchschnitt;
                besterStudent = studentName;
            }
        }
        
        return (besterStudent, besterDurchschnitt);
    }

    private static void DictionaryAufgabe2Zusatzb()
    {
        List<string> woerter = ["Apfel", "Banane", "Apfel", "Orange", "Banane", "Apfel"];

        for (int i = 0; i < woerter.Count; i++)
        {
            int count = 1;
            bool schonGesehen = false;

            for (int j = 0; j < i; j++)
            {
                if (woerter[i] == woerter[j])
                {
                    schonGesehen = true;
                    break;
                }
            }

            if (!schonGesehen)
            {
                for (int j = i + 1; j < woerter.Count; j++)
                {
                    if (woerter[i] == woerter[j])
                    {
                        count++;
                    }
                }

                Console.WriteLine($"{woerter[i]}: {count} mal");
            }
        }
    }

    private static void DictionaryAufgabe2_3()
    {
        var noten = new Dictionary<string, List<int>>
        {
            { "Alice", new List<int> { 96, 88, 92 } },
            { "Bob", new List<int> { 76, 80, 78 } },
            { "Charlie", new List<int> { 91, 93, 89 } }
        };
        
        var durchschnittsnoten = DurchschnittsnotenTupel(noten);

        foreach (var eintrag in durchschnittsnoten)
        {
            Console.WriteLine($"{eintrag.Name}: {eintrag.Note}");
        }
    }

    private static List<(string Name, double Note)> DurchschnittsnotenTupel(Dictionary<string, List<int>> noten)
    {
        var result = new List<(string, double)>();

        foreach (var eintrag in noten)
        {
            var name = eintrag.Key;
            var notenliste = eintrag.Value;
            var durchschnittsnote = notenliste.Average();

            result.Add((name, durchschnittsnote));
        }

        return result;
    }

    private static void DictionaryAufgabe2_2()
    {
        var noten = new Dictionary<string, List<int>>
        {
            { "Alice", new List<int> { 96, 88, 92 } },
            { "Bob", new List<int> { 76, 80, 78 } },
            { "Charlie", new List<int> { 91, 93, 89 } }
        };
        
        var durchschnittsnoten = DurchschnittsnotenDictionary(noten);

        foreach (var eintrag in durchschnittsnoten)
        {
            Console.WriteLine($"{eintrag.Key}: {eintrag.Value}");
        }
    }

    private static Dictionary<string, double> DurchschnittsnotenDictionary(Dictionary<string, List<int>> noten)
    {
        var result = new Dictionary<string, double>();

        foreach (var eintrag in noten)
        {
            var name = eintrag.Key;
            var notenliste = eintrag.Value;
            var durchschnittsnote = notenliste.Average();

            result.Add(name, durchschnittsnote);
        }

        return result;
    }

    private static void DictionaryAufgabe2_1()
    {
        var noten = new Dictionary<string, List<int>>
        {
            { "Alice", new List<int> { 96, 88, 92 } },
            { "Bob", new List<int> { 76, 80, 78 } },
            { "Charlie", new List<int> { 91, 93, 89 } }
        };
        
        DurchschnittsnotenAusgeben(noten);
        // Ausgabe:
        // Alice: 92
        // Bob: 78
        // Charlie: 91
    }

    private static void DurchschnittsnotenAusgeben(Dictionary<string, List<int>> noten)
    {
        foreach (var eintrag in noten)
        {
            var name = eintrag.Key;
            var notenliste = eintrag.Value;
            var summe = 0;
            foreach (var note in notenliste)
            {
                summe += note;
            }

            // Cast nach double nicht vergessen, sonst wird ganzzahlige Division verwendet
            var durchschnittsnote = (double) summe / notenliste.Count;

            // Alternative mit Average
            durchschnittsnote = notenliste.Average();

            // Alternative mit Sum
            durchschnittsnote = (double) notenliste.Sum() / notenliste.Count;

            Console.WriteLine($"{name}: {durchschnittsnote}");
        }
    }

    private static void DictionaryAufgabe2Zusatz()
    {
        
        List<string> woerter = ["Apfel", "Banane", "Apfel", "Orange", "Banane", "Apfel"];

        var ergebnis = ZaehleWorteZusatz(woerter);

        foreach (var tuple in ergebnis)
        {
            System.Console.WriteLine(tuple);
        }
    }

    private static void DictionaryAufgabe2()
    {
        List<string> woerter = ["Apfel", "Banane", "Apfel", "Orange", "Banane", "Apfel"];

        Dictionary<string, int> ergebnis = ZaehleWorte(woerter);

        foreach (var eintrag in ergebnis)
        {
            Console.WriteLine($"{eintrag.Key}: {eintrag.Value}");
        }
        // Ausgabe:
        // Apfel: 3
        // Banane: 2
        // Orange: 1
    }

    private static Dictionary<string, int> ZaehleWorte(List<string> woerter)
    {
        var result = new Dictionary<string, int>();

        foreach (var wort in woerter)
        {
            if (result.ContainsKey(wort))
            {
                result[wort] = result[wort] + 1;
            }
            else
            {
                result[wort] = 1;
            }

            // // Alternative:
            // result[wort] = result.GetValueOrDefault(wort, 0) + 1;
        }

        return result;
    }

    private static List<(string, int)> ZaehleWorteZusatz(List<string> woerter)
    {
        // ["Apfel", "Banane", "Apfel", "Orange", "Banane", "Apfel"]
        // sortieren, dann Gruppen durchzählen
        // ["Apfel", "Apfel", "Apfel", "Banane", "Banane", "Orange"]

        woerter.Sort();

        var result = new List<(string, int)>();
        string aktuell = woerter[0];
        int count = 1;

        for (int i = 1; i < woerter.Count; i++)
        {
            if (woerter[i] == aktuell)
            {
                count++;
            }
            else
            {
                result.Add((aktuell, count));
                aktuell = woerter[i];
                count = 1;
            }
        }
        result.Add((aktuell, count));

        return result;
    }

    private static void DictionaryAufgabe1()
    {
            var telefonbuch = new Dictionary<string, string>
        {
            { "Alice", "555-598123"},
            { "Bob",   "555-934242"}
        };
        
        Console.WriteLine(SucheTelefonnummer(telefonbuch, "Bob"));
        //Ausgabe: 555-934242

        Console.WriteLine(SucheTelefonnummer(telefonbuch, "Malory"));
        //Ausgabe: Nicht gefunden
    }
    public static string SucheTelefonnummer(Dictionary<string, string> telefonbuch,
        string name)
    {
        if (telefonbuch.ContainsKey(name))
        {
            return telefonbuch[name];
        }

        return "Nicht gefunden";

        // // Alternative
        // return telefonbuch.GetValueOrDefault(name, "Nicht gefunden");
    }

    private static void ArrayAufgabe2()
    {
        var index = IndexVon_Tupel([2, 5, -17, 28], -17);
        Console.WriteLine(index); // Ausgabe: (2, -17)

        index = IndexVon_Tupel([2, 5, -17, 28], 3);
        Console.WriteLine(index); // Ausgabe: (-1, 3)
    }

    private static (int, int) IndexVon_Tupel(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            var element = array[i];

            if (element == value)
            {
                return (i, value);
            }
        }

        return (-1, value);
    }

    private static void ArrayAufgabe1()
    {
        var index = IndexVon([2, 5, -17, 28, -17], -17);
        Console.WriteLine(index); // Ausgabe: 2

        index = IndexVon([2, 5, -17, 28, -17], 3);
        Console.WriteLine(index); // Ausgabe: -1
    }

    private static int IndexVon(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            var element = array[i];

            if (element == value)
            {
                return i;
            }
        }

        return -1;

        // // Alternative mit Index()-Methode (die Tupel aus Index und Wert zurückgibt)
        // // [2, 5, -17, 28, -17]
        // // [(0, 2), (1, 5), (2, -17), (3, 28), (4, -17)]

        // foreach (var tuple in array.Index())
        // {
        //     if (tuple.Item == value)
        //     {
        //         return tuple.Index;
        //     }
        // }
    }

    private static void Tupel()
    {
        var person = GetPerson();

        Console.WriteLine($"Person, Name: {person.Name}, Alter: {person.Alter}");
    }

    private static (string Name, int Alter) GetPerson()
    {
        return ("Bob", 25);
    }

    private static void Dictionaries()
    {
        var grades = new Dictionary<string, int>
        {
            { "Alice", 95 },
            { "Bob", 85 },
            { "Charlie", 92 }
        };

        foreach (var grade in grades)
        {
            Console.WriteLine($"Student: {grade.Key}, Note: {grade.Value}");
        }

        // Lesend auf Dictionary zugreifen (könnte schief gehen wenn Key nicht vorhanden)
        Console.WriteLine(grades["David"]);

        // vorher Testen ob Key vorhanden
        if (grades.ContainsKey("David"))
        {
            Console.WriteLine(grades["David"]);
        }
        else
        {
            Console.WriteLine("Key Foo nicht gefunden");
        }

        // schlägt nicht fehl bei fehlendem Key
        grades.TryGetValue("David", out int gradeDavid);

        // Key-Value-Pair zu gegebenem Key entfernen
        grades.Remove("Alice");
    }

    private static void LinqSort()
    {
        int[] punkte = {78, 92, 97, 37, 81};

        foreach(var number in punkte.Order())
        {
            Console.Write(number + " ");
        }

        // Die Array-Klasse hat auch eine statische Methode für
        // in place Sortierung
        Array.Sort(punkte);
    }

    private static void Linq()
    {
        int[] punkte = {78, 92, 97, 37, 81};
        var min = punkte.Min();
        var max = punkte.Max();
        var sum = punkte.Sum();
        var count = punkte.Count();

        Console.WriteLine($"Die schlechteste Punktzahl ist {min}, die beste ist {max} und die Durchschnittspunktzahl ist {sum/count}");

        // Diese Funktionen gibt es auch bei anderen Datentypen, z.B. Listen:
        var punkteListe = new List<int> {78, 92, 97, 37, 81};
        min = punkteListe.Min();
        max = punkteListe.Max();
        sum = punkteListe.Sum();
        count = punkteListe.Count();
    }

    private static void ListenAufgabe2()
    {
        int[] zufallszahlen = new int[30];
        Random random = new Random();

        for (int i = 0; i < zufallszahlen.Length; i++)
        {
            var zufallszahl = random.Next(1, 101);
            zufallszahlen[i] = zufallszahl;
        }

        ArrayAusgeben(zufallszahlen);
    }

    private static void ArrayAusgeben(Array array)
    {
        foreach(var element in array)
        {
            Console.Write($"{element}, ");
        }
    }

    private static void ListenAufgabe1()
    {
        List<int> array = [4, 12, -100, 17, 1, 2, 3];

        // Alle Elemente ausgeben mit for
        for (int i = 0; i < array.Count; i++)
        {
            var element = array[i];

            Console.WriteLine(element);
        }

        // Alle Elemente ausgeben mit foreach
        foreach (var element in array)
        {
            Console.WriteLine(element);
        }
    }

    private static void Listen()
    {
        var lieblingsgetränk = new List<string>();

        // leere Liste []

        lieblingsgetränk.Add("Kaffee");
        lieblingsgetränk.Add("Kaffee");
        lieblingsgetränk.Add("Kaffee");
        lieblingsgetränk.Add("Wasser");
        // ["Kaffee", "Kaffee", "Kaffee", "Wasser"]

        // Liste ausgeben mit foreach-Schleife
        foreach (var getränk in lieblingsgetränk)
        {
            Console.WriteLine(getränk);
        }

        lieblingsgetränk.Remove("Kaffee");
        // ["Kaffee", "Kaffee", "Wasser"]

        // Liste ausgeben mit for-Schleife
        for (int i = 0; i < lieblingsgetränk.Count; i++)
        {
            Console.WriteLine(lieblingsgetränk[i]);
        }

        var erstes = lieblingsgetränk[0];
        // erstes == "Kaffee"

        lieblingsgetränk[0] = "Apfelschorle";
        // ["Apfelschorle", "Kaffee", "Wasser"]

        var längeVonListe = lieblingsgetränk.Count;
        // 3
    }

    private static void SchleifenAufgabe2()
    {
        Console.Write("Positive Zahl: ");

        int ziel = Convert.ToInt32(Console.ReadLine());

        Console.Write("(1");

        int summe = 1;
        for (int i = 2; i <= ziel; i++)
        {
            Console.Write($" + {i}");
            summe += i;
        }

        Console.Write($") * 2 = {summe * 2}");
    }

    private static void SchleifenAufgabe2b()
    {
        // Mit while statt for
        
        Console.Write("Positive Zahl: ");

        int ziel = Convert.ToInt32(Console.ReadLine());

        Console.Write("(1");

        int summe = 1;
        int i = 2;
        while (i <= ziel)
        {
            Console.Write($" + {i}");
            summe += i;
            i++;
        }

        Console.Write($") * 2 = {summe * 2}");
    }

    private static void SchleifenAufgabe1()
    {
        Console.Write("Positive Zahl: ");

        int ziel = Convert.ToInt32(Console.ReadLine());

        int summe = 0;

        for (int i = 1; i <= ziel; i++)
        {
            summe += i;
        }

        Console.WriteLine($"Die Summe ist {summe}");

        // Alternative mit While

        Console.Write("Positive Zahl: ");

        ziel = Convert.ToInt32(Console.ReadLine());

        summe = 0;
        int n = 1;
        while ( n <= ziel)
        {
            summe += n;
            n++;
        }

        Console.WriteLine($"Die Summe ist {summe}");
    }


    private static void Schleifen()
    {
        // Variable von 0 bis 4 inklusive hochzählen und ausgeben
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        // dasselbe mit while:

        int n = 0;
        while (n < 5)
        {
            Console.WriteLine(n);

            n++;
        }
    }

    private static void Verzweigungen()
    {
        int x = 3;
        int y = 10;

        if (x > y)
        {
            Console.WriteLine("x ist größer als y");
        }
        else if(x == y)
        {
            Console.WriteLine("x ist gleich y");
        }
        else
        {
            Console.WriteLine("x ist kleiner als y");
        }

    }

    // Aufgabe 1 vom 11.06.
    static void ErsteAufgabe()
    {
        Console.Write("Geben Sie die erste Zahl ein: ");
        int numberOne = int.Parse(Console.ReadLine()!);
 
        Console.Write("Geben Sie die zweite Zahl ein: ");
        int numberTwo = int.Parse(Console.ReadLine()!);
 
        int sum = numberOne + numberTwo;
        Console.WriteLine($"Die Summe von {numberOne} + {numberTwo} = {sum}");
    }
 
    // Aufgabe 2 vom 11.06.
    static void ZweiteAufgabe()
    {
        Console.Write("Geben Sie 'a' ein: ");
        int a = int.Parse(Console.ReadLine()!);
 
        Console.Write("Geben Sie 'b' ein: ");
        int b = int.Parse(Console.ReadLine()!);
 
        var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
 
        Console.WriteLine($"c = √a2 + b2 = {c}");
    }

    private static void LogischeOperatoren()
    {
        var a = 3 >= 4;
        var b = "foo" == "foo";

        var ergebnis = a && b;
        ergebnis = a || b;
        ergebnis = !b;

        ergebnis = !a && b || 5 > 4;
    }

    private static void VergleichsOperatoren()
    {
        var foo = 3 == 4;
        foo = 3 != 4;
        foo = 3 < 4;
        foo = 3 > 4;
        foo = 3 <= 4;
        foo = 3 >= 4;
    }

    private static void ArithmetischeOperatoren()
    {
        // Addition
        var ergebnis = 3 + 5;

        // Subtraktion
        ergebnis = 3 - 5;

        // Multiplikation
        ergebnis = 3 * 5;

        // Division (ganzzahlig)
        ergebnis = 6 / 4;

        // liefert 1 (statt 1.5)
        Console.WriteLine(ergebnis);

        // Division (double)
        var quotient = 6.0 / 4.0;
        
        // liefert "erwartungsgemäß" 1.5
        Console.WriteLine(quotient);

        // Modulo-Operator (Rest bei Ganzzahl-Division)
        var rest = 6 % 4;

        // Inkrement-Operator (hochzählen um 1)
        ergebnis++;

        // Dekrement-Operator (runterzählen um 1)
        ergebnis--;

        // Zusammengesetzen Zuweisungsoperatoren (compound assignments)
        ergebnis += 5; // ergebnis = ergebnis + 5;
        ergebnis -= 5; // ergebnis = ergebnis - 5;
        ergebnis *= 5; // ergebnis = ergebnis * 5;
        ergebnis /= 5; // ergebnis = ergebnis / 5;
        ergebnis %= 5; // ergebnis = ergebnis % 5;
    }

    private static void TypUmwandlungen()
    {
        // UTF-8 oder ASCII "420"
        // 00110100 00110010 00110000
        string zahlAlsString = "420";

        // diese Zahl als int (32 bit Integer mit Vorzeichen)
        // 0000 0000 0000 0000 0000 0001 1010 0100
        int zahl = Convert.ToInt32(zahlAlsString);
        
        // Implizite Typunwandlung (type cast), z.B. int in long -> ohne Probleme möglich, deswegen nicht explizit nötig
        long großeZahl = zahl;

        // Explizite Typumwandlung
        zahl = (int)großeZahl;

        // Suffixe für literale der numerischen Typen:

        // decimal
        var dec = 3.4m;

        // float
        var fl = 3.4f;

        // double
        var doub = 3.4;

        // ganze Zahl aber binär angegeben (und mit optionalen Trennzeichen "_")
        zahl = 0b_0001_0101_0110;

        // ganze Zahl aber hexadezimal angegeben
        zahl = 0xCAFE;

        // Suffix für long-Literal
        var andereZahl = 1L;

        // Suffix für unsigned-Literal
        andereZahl = 1U;
    }

    private static void EinUndAusgabe()
    {
        Console.WriteLine("Das ist eine ganze Zeile.");
        Console.WriteLine("Das ist noch eine ganze Zeile.");

        Console.WriteLine("Wie heißt du?");
        var name = Console.ReadLine();

        Console.WriteLine("Hallo " + name);
    }

    private static void Variablen()
    {
        // Deklaration kann separat (von Zuweisung) passieren:
        string name;

        // Zuweisung
        name = "Max";

        // Zuweisung nur mit richtigem Typ möglich (statisch Typisierte Programmiersprache)
        // name = 3;

        // Deklaration und Zuweisung in einem Schritt
        int zahl = 3;

        // Impliziter Typ mit Keyword var (geht nur bei gleichzeitiger Initialisierung)
        var foo = 10.1;
    }

    private static void HelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }
}

class Foo
{
    public void Bar() {}
}