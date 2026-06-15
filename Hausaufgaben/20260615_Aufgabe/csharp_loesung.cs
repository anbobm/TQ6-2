

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Geben Sie ein Zahl ein: ");
        int userInput = int.Parse(Console.ReadLine());
        AufgabeEins(userInput);
        AufgabeZwei(userInput);
    }

    //Aufgabe 1
    public static void AufgabeEins(int number)
    {
        int summe = 0;
        //Methode 1
        for(int i = 1; i <= number; i++)
        {
            summe += i;
        }

        System.Console.WriteLine($"(for-schleife) Die Summe von 1 bis {number} ist gleich {summe}");
        
        int _summe = 0;
        int _i = 0;
        //Methode 2
        while (_i <= number)
        {
            _summe += _i;
            _i++;
        }
        System.Console.WriteLine($"(while-schleife) Die Summe von 1 bis {number} ist gleich {_summe}");
    }

    //Aufgabe 2

    public static void AufgabeZwei(int number)
    {
        int summe = 0;
        int result = 0;

        for(int i = 1; i <= number; i++)
        {
            summe += i;
        }
        result = summe * 2;

        System.Console.WriteLine($"Die Summe von 1 bis {number} ist gleich {summe}\n und Ergebniss von mal Operation {result}");
    }
}