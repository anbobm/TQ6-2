//# Aufgabe 1
//Erzeuge ein Array mit 7 Elementen. Nimm eine `for`-Schleife um der Reihe nach alle Elemente auf die Kommandozeile auszugeben.
//Anschließend tue dasselbe mit einer `foreach`-Schleife.

//# Aufgabe 2
//Erstelle ein Integer-Array mit 30 Plätzen. 
//Fülle mit einer `for`-Schleife das Array mit Zufallszahlen zwischen 1 und 100.

internal class Program
{
    private static void Main(string[] args)
    {
        AufgabeZwei();
    }

    private static void AufgabeEins()
    {
        int[] numbers = new int[7] {0, 1, 2, 3, 4, 5, 6};

        for (int i = 0; i < numbers.Length; i++)
        {
            System.Console.WriteLine($"Number with index {i} is {numbers[i]}");
        }

        foreach(var num in numbers)
        {
            System.Console.WriteLine($"(foreach) ELement: {num}");
        }
    }
    
    private static void AufgabeZwei()
    {
        int[] array = new int[30];
        Random random = new Random();

        for(int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
            System.Console.WriteLine($"Random number with index {i} is {array[i]}");
        }
    }
}