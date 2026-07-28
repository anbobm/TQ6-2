using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        // Aufgabe 1
        
        var noten1 = new Dictionary<string, List<int>>
        {
            { "Alice", new List<int> { 96, 88, 92 } },
            { "Bob", new List<int> { 76, 80, 78 } },
            { "Charlie", new List<int> { 91, 93, 89 } }
        };

        Console.WriteLine("\nAufgabe 1");
        DurchschnittsnotenAusgeben(noten1);


        
        // Aufgabe 2
        
        Console.WriteLine("\nAufgabe 2");
        var ergebnis2 = DurchschnittsnotenDictionary(noten1);

        foreach (var eintrag in ergebnis2)
            Console.WriteLine($"{eintrag.Key}: {eintrag.Value}");


        
        // Aufgabe 3
        
        Console.WriteLine("\nAufgabe 3");
        var ergebnis3 = DurchschnittsnotenTupel(noten1);

        foreach (var tupel in ergebnis3)
            Console.WriteLine($"{tupel.Name}: {tupel.Durchschnitt}");


        
        // Aufgabe 4
       
        Console.WriteLine("\nAufgabe 4");

        var noten4 = new Dictionary<string, Dictionary<string, int>>
        {
            { "Alice", new Dictionary<string, int> { { "Mathematik", 95 }, { "Englisch", 88 }, { "Geschichte", 92 } } },
            { "Bob", new Dictionary<string, int> { { "Mathematik", 75 }, { "Englisch", 82 }, { "Geschichte", 78 } } },
            { "Charlie", new Dictionary<string, int> { { "Mathematik", 88 }, { "Englisch", 91 }, { "Geschichte", 85 } } },
            { "Diana", new Dictionary<string, int> { { "Mathematik", 92 }, { "Englisch", 89 }, { "Geschichte", 94 } } }
        };

        var beste = BesterStudent(noten4);

        foreach (var tupel in beste)
            Console.WriteLine($"{tupel.Name}: {tupel.Durchschnitt}");
    }


    // Aufgabe 1
        static void DurchschnittsnotenAusgeben(Dictionary<string, List<int>> noten)
    {
        foreach (var eintrag in noten)
        {
            int summe = 0;
            foreach (int n in eintrag.Value)
                summe += n;

            int durchschnitt = summe / eintrag.Value.Count;

            Console.WriteLine($"{eintrag.Key}: {durchschnitt}");
        }
    }


    // Aufgabe 2
    
    static Dictionary<string, int> DurchschnittsnotenDictionary(Dictionary<string, List<int>> noten)
    {
        var ergebnis = new Dictionary<string, int>();

        foreach (var eintrag in noten)
        {
            int summe = 0;
            foreach (int n in eintrag.Value)
                summe += n;

            int durchschnitt = summe / eintrag.Value.Count;

            ergebnis.Add(eintrag.Key, durchschnitt);
        }

        return ergebnis;
    }


    
    // Aufgabe 3
        static List<(string Name, int Durchschnitt)> DurchschnittsnotenTupel(Dictionary<string, List<int>> noten)
    {
        var liste = new List<(string, int)>();

        foreach (var eintrag in noten)
        {
            int summe = 0;
            foreach (int n in eintrag.Value)
                summe += n;

            int durchschnitt = summe / eintrag.Value.Count;

            liste.Add((eintrag.Key, durchschnitt));
        }

        return liste;
    }


    
    // Aufgabe 4 
   
    static List<(string Name, int Durchschnitt)> BesterStudent(Dictionary<string, Dictionary<string, int>> noten)
    {
        var besteListe = new List<(string, int)>();
        int besterDurchschnitt = -1;

        foreach (var student in noten)
        {
            int summe = 0;
            int anzahl = student.Value.Count;

            foreach (var fachNote in student.Value)
                summe += fachNote.Value;

            int durchschnitt = summe / anzahl;

            if (durchschnitt > besterDurchschnitt)
            {
                besterDurchschnitt = durchschnitt;
                besteListe.Clear();
                besteListe.Add((student.Key, durchschnitt));
            }
            else if (durchschnitt == besterDurchschnitt)
            {
                besteListe.Add((student.Key, durchschnitt));
            }
        }

        return besteListe;
    }
}
