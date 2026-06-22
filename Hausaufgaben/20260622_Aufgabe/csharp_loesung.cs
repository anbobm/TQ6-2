using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgaben
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(Durschnitt(numbers));
        }

        public static double Durschnitt(List<int> numbers)
        {
            return (double)numbers.Average();
        }
    }
}