internal class Program
{
    internal static void Main(string[] args)
    {

    }

    public static void Aufgabe_2()
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

        if (studenten.TryGetValue(eingabe, out var faecher))
        {
            foreach (var fach in faecher)
            {
                Console.WriteLine($"{fach.Key}: {fach.Value}");
            }
        }
        else
        {
            Console.WriteLine($"Fehler: Der Student '{eingabe}' existiert nicht in der Datenbank.");
        }
    }

    public static void Aufgabe_1_2()
    {
        if(!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Fehler! Keine gueltige Ganzzahl eingegeben.");
            return;
        }
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Fehler! Keine gueltige Ganzzahl eingegeben.");
            return;
        }
        if(b == 0)
        {
            Console.WriteLine("Division durch 0 ist verboten.");
            return;
        }

        double result = (double)a / b;
        Console.WriteLine(result);
    }

    public static void Aufgabe_1_1()
    {
        try
        {
            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            double result = a / b;
            Console.WriteLine(result);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Fehler: Die Eingabe hatte das falsche Format!");
            Console.WriteLine($"Details: {ex.Message}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Fehler: Die eingegebene Zahl ist zu groß oder zu klein.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Divide by zero is forbidden");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}