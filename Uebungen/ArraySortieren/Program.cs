using System;

class Program
{
    static void Main(string[] args)
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        // Order-IDs splitten
        string[] orders = orderStream.Split(',');

        // Sortieren
        Array.Sort(orders);

        // Ausgabe + Fehler markieren
        foreach (string order in orders)
        {
            if (order.Length == 4)
            {
                Console.WriteLine(order);
            }
            else
            {
                Console.WriteLine($"{order}   - Error");
            }
        }
    }
}
