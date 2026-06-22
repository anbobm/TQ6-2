internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[5] {1, 3, 7, 7, 9};

        //Aufgabe 1
        int result = IndexVon(array, 7);
        System.Console.WriteLine($"Result: {result}");

        //Aufgabe 2
        var ausgabe = IndexVon_Tupel(array, 9);
        System.Console.WriteLine($"Index = {ausgabe.index}, Element = {ausgabe.value}");
    }

    public static int IndexVon(int[] array, int value)
    {
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == value)
                return i;
        }
        return -1;
    }

    public static (int index, int value) IndexVon_Tupel(int[]array, int value)
    {
        
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == value)
                return (i, array[i]);
        }
        return (-1, -1);
    }
}