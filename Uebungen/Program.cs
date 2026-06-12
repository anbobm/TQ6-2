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

        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }

            Console.WriteLine($"Your total including the bonus: {total}");
        }

            if (total >= 16)
        {
            Console.WriteLine("You win a new car!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("You win a new laptop!");
        }
        else if (total == 7)
        {
            Console.WriteLine("You win a trip for two!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }

        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;



        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 5)
        {
            discountPercentage = 10;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }


    }
}
