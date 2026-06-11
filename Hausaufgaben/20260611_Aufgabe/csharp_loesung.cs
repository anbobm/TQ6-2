internal class Program
{
    private static void Main(string[] args)
    {
        ErsteAufgabe();
        ZweiteAufgabe();
    }

    static void ErsteAufgabe()
    {
        Console.Write("Geben Sie die erste Zahl ein: ");
        int numberOne = int.Parse(Console.ReadLine()!);

        Console.Write("Geben Sie die zweite Zahl ein: ");
        int numberTwo = int.Parse(Console.ReadLine()!);

        int sum = numberOne + numberTwo;
        Console.WriteLine($"Die Summe von {numberOne} + {numberTwo} = {sum}");
    }

    static void ZweiteAufgabe()
    {
        Console.Write("Geben Sie 'a' ein: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Geben Sie 'b' ein: ");
        int b = int.Parse(Console.ReadLine()!);

        var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        Console.WriteLine($"c = √a2 + b2 = {c}");
    }
}