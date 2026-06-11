internal class Program
{
    private static void Main(string[] args)
    {
        // HelloWorld();
        // Variablen();
        // EinUndAusgabe();
        TypUmwandlungen();
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