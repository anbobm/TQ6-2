using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
   
    // Aufgabe 1
    
    public static void Aufgabe1()
    {
        var noten = new Dictionary<string, List<int>>
        {
            { "Alice", new List<int> { 95, 88, 92 } },
            { "Bob", new List<int> { 75, 80, 78 } },
            { "Charlie", new List<int> { 91, 93, 89 } }
        };

        Console.WriteLine("Aufgabe 1:");

        foreach (var eintrag in noten)
        {
            int summe = 0;
            for (int i = 0; i < eintrag.Value.Count; i++)
                summe += eintrag.Value[i];

            int durchschnitt = summe / eintrag.Value.Count;

            Console.WriteLine($"{eintrag.Key,-10} {durchschnitt}");
        }

        Console.WriteLine(); 
    }

    
        public static void Aufgabe2()
    {
        var noten = new Dictionary<string, List<int>>
        {
            { "Alice", new List<int> { 95, 88, 92 } },
            { "Bob", new List<int> { 75, 80, 78 } },
            { "Charlie", new List<int> { 91, 93, 89 } }
        };

        var ergebnis = new Dictionary<string, int>();

        foreach (var eintrag in noten)
        {
            int summe = 0;
            for (int i = 0; i < eintrag.Value.Count; i++)
                summe += eintrag.Value[i];

            int durchschnitt = summe / eintrag.Value.Count;
            ergebnis[eintrag.Key] = durchschnitt;
        }

        Console.WriteLine("Aufgabe 2:");

        foreach (var eintrag in ergebnis)
        {
            Console.WriteLine($"{eintrag.Key,-10} {eintrag.Value}");
        }

        Console.WriteLine(); 
    }

    
    // Aufgabe 3
   
    public static void Aufgabe3()
    {
        var noten = new Dictionary<string, List<int>>
        {
            { "Alice", new List<int> { 95, 88, 92 } },
            { "Bob", new List<int> { 75, 80, 78 } },
            { "Charlie", new List<int> { 91, 93, 89 } }
        };

        var liste = new List<(string Name, int Durchschnitt)>();

        foreach (var eintrag in noten)
        {
            int summe = 0;
            for (int i = 0; i < eintrag.Value.Count; i++)
                summe += eintrag.Value[i];

            int durchschnitt = summe / eintrag.Value.Count;
            liste.Add((eintrag.Key, durchschnitt));
        }

        Console.WriteLine("Aufgabe 3:");

        for (int i = 0; i < liste.Count; i++)
        {
            Console.WriteLine($"{liste[i].Name,-10} {liste[i].Durchschnitt}");
        }

        Console.WriteLine();
    }

    // Aufgabe 4 – Bester Student
   
    public static (string Name, double Durchschnitt) BesterStudent(
        Dictionary<string, Dictionary<string, int>> noten)
    {
        string besterName = "";
        double besterDurchschnitt = double.MinValue;

        foreach (var student in noten)
        {
            string name = student.Key;
            var faecher = student.Value;

            double durchschnitt = faecher.Values.Average();

            if (durchschnitt > besterDurchschnitt)
            {
                besterDurchschnitt = durchschnitt;
                besterName = name;
            }
        }

        return (besterName, besterDurchschnitt);
    }

    static void Main(string[] args)
    {
        Aufgabe1();
        Aufgabe2();
        Aufgabe3();

        // Aufgabe 4 – Beispiel-Daten
        var notenAufgabe4 = new Dictionary<string, Dictionary<string, int>>
        {
            { "Alice", new Dictionary<string, int> { { "Mathematik", 95 }, { "Englisch", 88 }, { "Geschichte", 92 } } },
            { "Bob", new Dictionary<string, int> { { "Mathematik", 75 }, { "Englisch", 82 }, { "Geschichte", 78 } } },
            { "Charlie", new Dictionary<string, int> { { "Mathematik", 88 }, { "Englisch", 91 }, { "Geschichte", 85 } } },
            { "Diana", new Dictionary<string, int> { { "Mathematik", 92 }, { "Englisch", 89 }, { "Geschichte", 94 } } }
        };

        var bester = BesterStudent(notenAufgabe4);

        Console.WriteLine("Aufgabe 4: Bester Student:");
        Console.WriteLine($"{bester.Name,-10} {bester.Durchschnitt}");
        Console.WriteLine();
    }
}
