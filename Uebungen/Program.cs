using System;

class Program
{
    static void Main()
    {
        // Addition
        int firstNumber = 12;
        int secondNumber = 7;
        Console.WriteLine(firstNumber + secondNumber);

        // String + int
        string firstName = "Bob";
        int widgetsSold = 7;
        Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

        // String + int + int
        Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

        // Klammern für richtige Addition
        Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

        // Grundrechenarten
        int sum = 7 + 5;
        int difference = 7 - 5;
        int product = 7 * 5;
        int quotient = 7 / 5;
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Quotient: " + quotient);

        // Dezimaldivision
        decimal decimalQuotient1 = 7.0m / 5;
        Console.WriteLine(decimalQuotient1);

        decimal decimalQuotient2 = 7 / 5.0m;
        Console.WriteLine(decimalQuotient2);

        decimal decimalQuotient3 = 7.0m / 5.0m;
        Console.WriteLine(decimalQuotient3);

        // Casting
        int first = 7;
        int second = 5;
        decimal castQuotient = (decimal)first / (decimal)second;
        Console.WriteLine(castQuotient);

        // Modulo
        Console.WriteLine(200 % 5);
        Console.WriteLine(7 % 5);

        // Reihenfolge der Operationen
        int value1 = 3 + 4 * 5;
        int value2 = (3 + 4) * 5;
        Console.WriteLine(value1);
        Console.WriteLine(value2);

        // Inkrement
        int value = 1;
        value = value + 1;
        Console.WriteLine(value);

        value += 1;
        Console.WriteLine(value);

        value++;
        Console.WriteLine(value);

        // Dekrement
        value = value - 1;
        Console.WriteLine(value);

        value -= 1;
        Console.WriteLine(value);

        value--;
        Console.WriteLine(value);

        // Prefix/Postfix
        int v = 1;
        v++;
        Console.WriteLine(v);

        Console.WriteLine(v++);
        Console.WriteLine(v);

        Console.WriteLine(++v);

        // Fahrenheit → Celsius
        int fahrenheit = 94;
        decimal celsius = (fahrenheit - 32m) * (5m / 9m);
        Console.WriteLine("The temperature is " + celsius + " Celsius.");

        // Aufgabe 1
        int x = 7;
        int y = 3;
        Console.WriteLine("Addition: " + x + " + " + y + " = " + (x + y));

        // Aufgabe 2 
        int a = 18;
        int b = 8;
        int c = a * a + b * b;
        Console.WriteLine(Math.Sqrt(c));
    }
}
