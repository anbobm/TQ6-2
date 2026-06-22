internal partial class Program
{
    private static void Main(string[] args)
    {
        var telefonbuch = new Dictionary<string, string>
        {
            { "Alice", "555-598123"},
            { "Bob", "555-934242"}
        };
    
        Console.WriteLine(SucheTelefonnummer(telefonbuch, "Bob"));
        //Ausgabe: 555-934242

        //Console.WriteLine(SucheTelefonnummer(telefonbuch, "Malory"));
        //Ausgabe: Nicht gefunden
    }

    public static string SucheTelefonnummer(Dictionary<string, string> telefonbuch,
    string name)
    {
        foreach(var person in telefonbuch)
        {
            if (person.Key == name)
            {
                return $"Ausgabe: {name}: {person.Value}";
            }
        }
        return "Nicht gefunden";
    }

    public static Dictionary<string, int> ZaehleWorte(List<string> woerter)
    {
        Dictionary<string, int> ergebnis = new Dictionary<string, int>();

        foreach (string wort in woerter)
        {
            if (ergebnis.ContainsKey(wort))
            {
                ergebnis[wort]++;
            }
            else
            {
                ergebnis[wort] = 1;
            }
        }

        return ergebnis;
    }
}