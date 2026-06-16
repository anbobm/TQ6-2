internal partial class Program
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
        // ErsteAufgabe();
        // Verzweigungen();
        // Schleifen();
        // SchleifenAufgabe1();
        // SchleifenAufgabe2();
    }

    private static void Listen()
    {
        var lieblingsgetränk = new List<string>();

        // leere Liste []

        lieblingsgetränk.Add("Kaffee");
        lieblingsgetränk.Add("Kaffee");
        lieblingsgetränk.Add("Kaffee");
        lieblingsgetränk.Add("Wasser");
        // ["Kaffee", "Kaffee", "Kaffee", "Wasser"]

        lieblingsgetränk.Remove("Kaffee");
        // ["Kaffee", "Kaffee", "Wasser"]

        var erstes = lieblingsgetränk[0];
        // erstes == "Kaffee"

        lieblingsgetränk[0] = "Apfelschorle";
        // ["Apfelschorle", "Kaffee", "Wasser"]

        var längeVonListe = lieblingsgetränk.Count;
        // 3
    }

    private static void SchleifenAufgabe2()
    {
        Console.Write("Positive Zahl: ");

        int ziel = Convert.ToInt32(Console.ReadLine());

        Console.Write("(1");

        int summe = 1;
        for (int i = 2; i <= ziel; i++)
        {
            Console.Write($" + {i}");
            summe += i;
        }

        Console.Write($") * 2 = {summe * 2}");
    }

    private static void SchleifenAufgabe2b()
    {
        // Mit while statt for
        
        Console.Write("Positive Zahl: ");

        int ziel = Convert.ToInt32(Console.ReadLine());

        Console.Write("(1");

        int summe = 1;
        int i = 2;
        while (i <= ziel)
        {
            Console.Write($" + {i}");
            summe += i;
            i++;
        }

        Console.Write($") * 2 = {summe * 2}");
    }

    private static void SchleifenAufgabe1()
    {
        Console.Write("Positive Zahl: ");

        int ziel = Convert.ToInt32(Console.ReadLine());

        int summe = 0;

        for (int i = 1; i <= ziel; i++)
        {
            summe += i;
        }

        Console.WriteLine($"Die Summe ist {summe}");

        // Alternative mit While

        Console.Write("Positive Zahl: ");

        ziel = Convert.ToInt32(Console.ReadLine());

        summe = 0;
        int n = 1;
        while ( n <= ziel)
        {
            summe += n;
            n++;
        }

        Console.WriteLine($"Die Summe ist {summe}");
    }


    private static void Schleifen()
    {
        // Variable von 0 bis 4 inklusive hochzählen und ausgeben
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        // dasselbe mit while:

        int n = 0;
        while (n < 5)
        {
            Console.WriteLine(n);

            n++;
        }
    }

    private static void Verzweigungen()
    {
        int x = 3;
        int y = 10;

        if (x > y)
        {
            Console.WriteLine("x ist größer als y");
        }
        else if(x == y)
        {
            Console.WriteLine("x ist gleich y");
        }
        else
        {
            Console.WriteLine("x ist kleiner als y");
        }

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