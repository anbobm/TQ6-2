using System;

class Program
{
    // Aufgabe 1 
    static int IndexVon(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] == value)
                return i;

        return -1;
    }

    // Aufgabe 2 
    static (int Index, int Value) IndexVon_Tupel(int[] array, int value)
    {
        int index = IndexVon(array, value);
        return (index, value);
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Aufgabe 1");
        Console.WriteLine(IndexVon(new int[] { 2, 5, -17, 28 }, -17)); 
        Console.WriteLine(IndexVon(new int[] { 2, 5, -17, 28 }, 3));   
        Console.WriteLine();

        Console.WriteLine("Aufgabe 2");
        Console.WriteLine(IndexVon_Tupel(new int[] { 2, 5, -17, 28 }, -17)); 
    }
}
