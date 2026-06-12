internal class Program
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
        ErsteAufgabe();
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