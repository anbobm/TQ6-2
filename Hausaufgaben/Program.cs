using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    
    // Aufgabe 1
    public static string SucheTelefonnummer(Dictionary<string, string> telefonbuch, string name)
    {
        if (telefonbuch.ContainsKey(name))
            return telefonbuch[name];

        return "Nicht gefunden!";
    }

    public static void Aufgabe1()
    {
        Console.WriteLine("Aufgabe 1:");

        var telefonbuch = new Dictionary<string, string>
        {
            { "Alice", "555-598123" },
            { "Bob",   "555-934242" }
        };

        Console.WriteLine("Bob: " + SucheTelefonnummer(telefonbuch, "Bob"));
        Console.WriteLine(SucheTelefonnummer(telefonbuch, "Malory"));
    }

   
    // Aufgabe 2 (Dictionary)
    public static Dictionary<string, int> ZaehleWorte(List<string> woerter)
    {
        Dictionary<string, int> ergebnis = new Dictionary<string, int>();

        for (int i = 0; i < woerter.Count; i++)
        {
            string wort = woerter[i];

            if (ergebnis.ContainsKey(wort))
                ergebnis[wort]++;
            else
                ergebnis[wort] = 1;
        }

        return ergebnis;
    }

    public static void Aufgabe2()
    {
        Console.WriteLine("\nAufgabe 2:");

        List<string> woerter = new List<string>
        {
            "Apfel", "Banane", "Apfel", "Orange", "Banane", "Apfel"
        };

        var ergebnis = ZaehleWorte(woerter);

        for (int i = 0; i < ergebnis.Count; i++)
        {
            var element = ergebnis.ElementAt(i);
            Console.WriteLine($"{element.Key}: {element.Value}");
        }
    }


    // Aufgabe 2 Zusatz 
    public static List<(string Wort, int Anzahl)> ZaehleWorteOhneDictionary(List<string> woerter)
    {
        List<(string Wort, int Anzahl)> ergebnis = new List<(string Wort, int Anzahl)>();

        for (int i = 0; i < woerter.Count; i++)
        {
            string wort = woerter[i];
            bool gefunden = false;

            for (int j = 0; j < ergebnis.Count; j++)
            {
                if (ergebnis[j].Wort == wort)
                {
                    ergebnis[j] = (wort, ergebnis[j].Anzahl + 1);
                    gefunden = true;
                    break;
                }
            }

            if (!gefunden)
                ergebnis.Add((wort, 1));
        }

        return ergebnis;
    }

    public static void Aufgabe2Zusatz()
    {
        Console.WriteLine("\nZusatz:");

        List<string> woerter = new List<string>
        {
            "Apfel", "Banane", "Apfel", "Orange", "Banane", "Apfel"
        };

        var ergebnis = ZaehleWorteOhneDictionary(woerter);

        string ausgabe = "";

        for (int i = 0; i < ergebnis.Count; i++)
        {
            ausgabe += $"{ergebnis[i].Wort}: {ergebnis[i].Anzahl}";

            if (i < ergebnis.Count - 1)
                ausgabe += " | ";
        }

        Console.WriteLine(ausgabe);
    }

      private static void Main(string[] args)
    {
        Aufgabe1();
        Aufgabe2();
        Aufgabe2Zusatz();
    }
}
