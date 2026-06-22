internal class Program
{
    private static void Main(string[] args)
    {
        var noten = new Dictionary<string, List<int>>
    {
        { "Alice", new List<int> { 95, 88, 92 } },
        { "Bob", new List<int> { 75, 80, 78 } },
        { "Charlie", new List<int> { 91, 93, 89 } }
    };

        var result = DurchschnittsnotenAusgeben(noten);
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Item1}: {item.Item2}");
        }
    }

    //Aufgabe 1
    //public static void DurchschnittsnotenAusgeben(Dictionary<string, List<int>> noten)
    //{
    //    foreach (var note in noten)
    //    {
    //        int average = (int)Math.Round(note.Value.Average());
    //        Console.WriteLine($"{note.Key}: {average}");
    //    }
    //}

    //Aufgabe 2
    //public static Dictionary<string, int> DurchschnittsnotenAusgeben(Dictionary<string, List<int>> noten)
    //{
    //    Dictionary<string, int> newNotenDict = new Dictionary<string, int>();

    //    foreach (var note in noten)
    //    {
    //        int average = (int)Math.Round(note.Value.Average());
    //        newNotenDict.Add(note.Key, average);
    //    }

    //    return newNotenDict;
    //}

    //Aufgabe 3
    public static List<(string, int)> DurchschnittsnotenAusgeben(Dictionary<string, List<int>> noten)
    {
        List<(string, int)> newNotenList = new  List<(string, int)>();

        foreach (var note in noten)
        {
            int average = (int)Math.Round(note.Value.Average());
            newNotenList.Add((note.Key, average));
        }

        return newNotenList;
    }
}