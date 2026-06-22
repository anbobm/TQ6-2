internal class Program
{
    private static void Main(string[] args)
    {
        var noten = new Dictionary<string, Dictionary<string, int>>
        {
            { "Alice", new Dictionary<string, int> { { "Mathematik", 95 }, { "Englisch", 88 }, { "Geschichte", 92 } } },
            { "Bob", new Dictionary<string, int> { { "Mathematik", 75 }, { "Englisch", 82 }, { "Geschichte", 78 } } },
            { "Charlie", new Dictionary<string, int> { { "Mathematik", 88 }, { "Englisch", 91 }, { "Geschichte", 85 } } },
            { "Diana", new Dictionary<string, int> { { "Mathematik", 92 }, { "Englisch", 89 }, { "Geschichte", 94 } } }
        };

        while (true)
        {
            ShowMenu();
            Console.Write("Select: ");

            if (!int.TryParse(Console.ReadLine(), out int selection))
            {
                Console.WriteLine("\nUngültige Eingabe! Bitte eine Zahl eingeben.");
                continue;
            }

            switch (selection)
            {
                case 1:
                    PrintAllStudents(noten);
                    break;
                case 2:
                    var bester = BesterStudent(noten);
                    Console.WriteLine($"\nDer beste Gesamtschüler ist {bester.name} mit einem Schnitt von {bester.schnitt:F2}");
                    break;
                case 3:
                    PrintBesteProFach(noten);
                    break;
                case 0:
                    Console.WriteLine("\nExit...");
                    return;
                default:
                    Console.WriteLine("\nIncorrect selection...Try again!");
                    break;
            }
        }
    }

    public static void ShowMenu()
    {
        Console.WriteLine("1. Show all students.");
        Console.WriteLine("2. Show best overall student.");
        Console.WriteLine("3. Show best students by subject.");
        Console.WriteLine("0. Exit.");
    }

    public static void PrintAllStudents(Dictionary<string, Dictionary<string, int>> noten)
    {
        Console.WriteLine();
        foreach (var schueler in noten)
        {
            Console.WriteLine($"Schüler: {schueler.Key}");
            foreach (var fach in schueler.Value)
            {
                Console.WriteLine($"  {fach.Key}: {fach.Value}");
            }
            Console.WriteLine();
        }
    }

    public static (string name, double schnitt) BesterStudent(Dictionary<string, Dictionary<string, int>> noten)
    {
        string besterName = "Keine Daten";
        double maximalerSchnitt = -1;

        foreach (var schueler in noten)
        {
            double aktuellerSchnitt = schueler.Value.Values.Average();

            if (aktuellerSchnitt > maximalerSchnitt)
            {
                maximalerSchnitt = aktuellerSchnitt;
                besterName = schueler.Key;
            }
        }

        return (besterName, maximalerSchnitt);
    }

    public static void PrintBesteProFach(Dictionary<string, Dictionary<string, int>> noten)
    {
        var faecher = noten.Values.SelectMany(d => d.Keys).Distinct();

        Console.WriteLine("\nBeste Schüler nach Fach");

        foreach (var fach in faecher)
        {
            string besterSchueler = "";
            int besteNote = -1;

            foreach (var schueler in noten)
            {
                if (schueler.Value.TryGetValue(fach, out int note))
                {
                    if (note > besteNote)
                    {
                        besteNote = note;
                        besterSchueler = schueler.Key;
                    }
                }
            }

            Console.WriteLine($"{fach}: {besterSchueler} ({besteNote} Punkte)");
        }
    }
}