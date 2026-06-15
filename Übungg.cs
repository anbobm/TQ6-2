// Console.Write("Gebe Sie die Erste Zahl ein: ");
// int numBerOne = int.Parse(Console.ReadLine() !);

// Console.Write("Gebe Sie die zweite Zahl ein ");
// int numberTwo = int.Parse(Console.ReadLine()!);

// int sum = numBerOne + numberTwo;

// Console.WriteLine($"Die Summer von {numBerOne} + {numberTwo} = {sum}");

// using System.Diagnostics.Contracts;

// Console.WriteLine();
// Console.Write("Bitte geben Sie den Gesamtpreis ein: ");

// // REPARATUR 1: Wir erstellen die Variable 'gesamtpreis' und lesen den Wert von der Tastatur ein!
// double gesamtpreis = double.Parse(Console.ReadLine()!);

// // REPARATUR 2: Wir schreiben 'rabatt' jetzt überall einheitlich mit zwei 't'
// double rabatt = 0;

// if (gesamtpreis > 100)
// {
//     rabatt = gesamtpreis * 0.10;
// }
// else
// {
//     rabatt = 0;
// }

// // Auch hier 'rabatt' mit zwei 't' benutzt
// gesamtpreis = gesamtpreis - rabatt;
// Console.WriteLine($"Der finale Endpreis nach Rabatt ist : {gesamtpreis} Euro");

Console.WriteLine("Bis zu welcher Zahl soll aufsummiert werden ");
int zielZahl = int.Parse(Console.ReadLine()!);
int summeFor = 0;

for (int i = 1; i <= zielZahl; i++)
{
    summeFor = summeFor + i;
}

Console.WriteLine($"[FOR] Die Summe von 1 bis {zielZahl} ist : {summeFor}");