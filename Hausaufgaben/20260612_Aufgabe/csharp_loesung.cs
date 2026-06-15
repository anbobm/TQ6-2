internal class Program
{
    private static void Main(string[] args)
    {
        int note;
        do
        {
            System.Console.Write("Geben Sie die Note ein: ");
            note = int.Parse(Console.ReadLine()); 
            Ergebniss(note);
        }while(note != 0);
    }

    private static void Ergebniss(int note)
    {
        switch (note)
        {
            case > 0 and < 30:
                Console.WriteLine("ungenügend");
                break;

            case > 30 and < 50:
                Console.WriteLine("mangelhaft");
                break;

            case >= 50 and <= 66:
                Console.WriteLine("ausreichend");
                break;

            case >= 67 and <= 80:
                Console.WriteLine("befriedigend");
                break;

            case > 80 and <= 91:
                Console.WriteLine("gut");
                break;

            case >= 92 and <= 100:
                Console.WriteLine("sehr gut");
                break;
            
            default:
                Console.WriteLine("Ungültige Punktzahl");
                break;
        }
    }
}
