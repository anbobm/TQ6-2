using System;
using System.Collections.Generic;

class Program
{
    // Aufgabe 1 
    public static void Aufgabe1()
    {
        var noten = new Dictionary<string, List<int>>();
        noten["Alice"] = new List<int> { 95, 88, 92 };
        noten["Bob"] = new List<int> { 75, 80, 78 };
        noten["Charlie"] = new List<int> { 91, 93, 89 };

        Console.WriteLine("Aufgabe 1:");

        foreach (var eintrag in noten)
        {
            int summe = 0;

            foreach (int note in eintrag.Value)
            {
                summe += note;
            }

            int durchschnitt = summe / eintrag.Value.Count;

            Console.WriteLine(eintrag.Key + " " + durchschnitt);
        }

        Console.WriteLine();
    }

   
    // Aufgabe 2 
    public static void Aufgabe2()
    {
        var noten = new Dictionary<string, List<int>>();
        noten["Alice"] = new List<int> { 95, 88, 92 };
        noten["Bob"] = new List<int> { 75, 80, 78 };
        noten["Charlie"] = new List<int> { 91, 93, 89 };

        var ergebnis = new Dictionary<string, int>();

        foreach (var eintrag in noten)
        {
            int summe = 0;

            foreach (int note in eintrag.Value)
            {
                summe += note;
            }

            int durchschnitt = summe / eintrag.Value.Count;

            ergebnis[eintrag.Key] = durchschnitt;
        }

        Console.WriteLine("Aufgabe 2:");

        foreach (var e in ergebnis)
        {
            Console.WriteLine(e.Key + " " + e.Value);
        }

        Console.WriteLine();
    }

    
    // Aufgabe 3 
       public static void Aufgabe3()
    {
        var noten = new Dictionary<string, List<int>>();
        noten["Alice"] = new List<int> { 95, 88, 92 };
        noten["Bob"] = new List<int> { 75, 80, 78 };
        noten["Charlie"] = new List<int> { 91, 93, 89 };

        var liste = new List<string>();

        foreach (var eintrag in noten)
        {
            int summe = 0;

            foreach (int note in eintrag.Value)
            {
                summe += note;
            }

            int durchschnitt = summe / eintrag.Value.Count;

            liste.Add(eintrag.Key + ": " + durchschnitt);
        }

        Console.WriteLine("Aufgabe 3:");

        foreach (var eintrag in liste)
        {
            Console.WriteLine(eintrag);
        }

        Console.WriteLine();
    }

    
    // Aufgabe 4 
    
   public static List<string> BesterStudent(Dictionary<string, Dictionary<string, int>> noten)
{
    double bester = -1;
    var beste = new List<string>();

    // Ersten Durchlauf: besten Durchschnitt finden
    foreach (var student in noten)
    {
        double summe = 0;

        foreach (var fach in student.Value)
        {
            summe += fach.Value;
        }

        double durchschnitt = summe / student.Value.Count;

        if (durchschnitt > bester)
        {
            bester = durchschnitt;
        }
    }

    // Zweiter Durchlauf: alle mit dem besten Durchschnitt sammeln
    foreach (var student in noten)
    {
        double summe = 0;

        foreach (var fach in student.Value)
        {
            summe += fach.Value;
        }

        double durchschnitt = summe / student.Value.Count;

        if (durchschnitt == bester)
        {
            beste.Add(student.Key + " " + durchschnitt);
        }
    }

    return beste;
}


static void Main(string[] args)
{
    Aufgabe1();
    Aufgabe2();
    Aufgabe3();

    // Aufgabe 4 – Beispiel-Daten
    var notenAufgabe4 = new Dictionary<string, Dictionary<string, int>>();
    notenAufgabe4["Alice"] = new Dictionary<string, int> { { "Mathematik", 95 }, { "Englisch", 88 }, { "Geschichte", 92 } };
    notenAufgabe4["Bob"] = new Dictionary<string, int> { { "Mathematik", 75 }, { "Englisch", 82 }, { "Geschichte", 78 } };
    notenAufgabe4["Charlie"] = new Dictionary<string, int> { { "Mathematik", 88 }, { "Englisch", 91 }, { "Geschichte", 85 } };
    notenAufgabe4["Diana"] = new Dictionary<string, int> { { "Mathematik", 92 }, { "Englisch", 89 }, { "Geschichte", 94 } };

    var beste = BesterStudent(notenAufgabe4);

    Console.WriteLine("Aufgabe 4: Bester Student:");

    foreach (var s in beste)
    {
        Console.WriteLine(s);
    }

    Console.WriteLine();
}

    }
