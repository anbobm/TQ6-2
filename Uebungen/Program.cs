using System;

class Programm
{
    static void Main()
    {
        AdditionUndStrings();
        Grundrechenarten();
        Dezimaldivision();
        Casting();
        Modulo();
        Reihenfolge();
        InkrementDekrement();
        PrefixPostfix();
        FahrenheitZuCelsius();
        Aufgabe1_Beispiel();
        Aufgabe2_Pythagoras();
        Wuerfelspiel();
        AboErinnerung();
        Noten();
        Aufgabe1_For_While();
        Aufgabe2_Multiplikation();
        FarbenAufgabe();
        Aufgabe2_Array30();
        BattleGame();

        // Codeprojekte
        Codeprojekt1_IntegerValidation();
        Codeprojekt2_StringValidation();
        Codeprojekt3_StringArrayProcessing();
    }

    // --- Aufgaben ---

    static void AdditionUndStrings()
    {
        int firstNumber = 12;
        int secondNumber = 7;
        Console.WriteLine(firstNumber + secondNumber);

        string firstName = "Bob";
        int widgetsSold = 7;

        Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
        Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
        Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
    }

    static void Grundrechenarten()
    {
        Console.WriteLine("Sum: " + (7 + 5));
        Console.WriteLine("Difference: " + (7 - 5));
        Console.WriteLine("Product: " + (7 * 5));
        Console.WriteLine("Quotient: " + (7 / 5));
    }

    static void Dezimaldivision()
    {
        Console.WriteLine(7.0m / 5);
        Console.WriteLine(7 / 5.0m);
        Console.WriteLine(7.0m / 5.0m);
    }

    static void Casting()
    {
        Console.WriteLine((decimal)7 / (decimal)5);
    }

    static void Modulo()
    {
        Console.WriteLine(200 % 5);
        Console.WriteLine(7 % 5);
    }

    static void Reihenfolge()
    {
        Console.WriteLine(3 + 4 * 5);
        Console.WriteLine((3 + 4) * 5);
    }

    static void InkrementDekrement()
    {
        int value = 1;

        value = value + 1; Console.WriteLine(value);
        value += 1; Console.WriteLine(value);
        value++; Console.WriteLine(value);

        value = value - 1; Console.WriteLine(value);
        value -= 1; Console.WriteLine(value);
        value--; Console.WriteLine(value);
    }

    static void PrefixPostfix()
    {
        int v = 1;

        v++; Console.WriteLine(v);
        Console.WriteLine(v++);
        Console.WriteLine(v);
        Console.WriteLine(++v);
    }

    static void FahrenheitZuCelsius()
    {
        int fahrenheit = 94;
        decimal celsius = (fahrenheit - 32m) * (5m / 9m);

        Console.WriteLine("The temperature is " + celsius + " Celsius.");
    }

    static void Aufgabe1_Beispiel()
    {
        Console.WriteLine("Addition: 7 + 3 = " + (7 + 3));
    }

    static void Aufgabe2_Pythagoras()
    {
        int a = 18;
        int b = 8;

        Console.WriteLine(Math.Sqrt(a * a + b * b));
    }

    static void Wuerfelspiel()
    {
        Random dice = new Random();

        int r1 = dice.Next(1, 7);
        int r2 = dice.Next(1, 7);
        int r3 = dice.Next(1, 7);

        int total = r1 + r2 + r3;

        Console.WriteLine($"Dice roll: {r1} + {r2} + {r3} = {total}");

        if (r1 == r2 || r2 == r3 || r1 == r3)
        {
            if (r1 == r2 && r2 == r3)
            {
                Console.WriteLine("You rolled triples! +6 bonus!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles! +2 bonus!");
                total += 2;
            }

            Console.WriteLine("Total: " + total);
        }

        if (total >= 16) Console.WriteLine("You win a new car!");
        else if (total >= 10) Console.WriteLine("You win a laptop!");
        else if (total == 7) Console.WriteLine("You win a trip!");
        else Console.WriteLine("You win a kitten!");
    }

    static void AboErinnerung()
    {
        Random random = new Random();
        int days = random.Next(12);

        if (days == 0) Console.WriteLine("Your subscription has expired.");
        else if (days == 1) Console.WriteLine("Expires within a day! Save 20%!");
        else if (days <= 5) Console.WriteLine($"Expires in {days} days! Save 10%!");
        else if (days <= 10) Console.WriteLine("Expires soon. Renew now!");
    }

    static void Noten()
    {
        Console.Write("Punktzahl (0–100): ");
        int p = int.Parse(Console.ReadLine());

        if (p >= 92) Console.WriteLine("sehr gut");
        else if (p >= 81) Console.WriteLine("gut");
        else if (p >= 67) Console.WriteLine("befriedigend");
        else if (p >= 50) Console.WriteLine("ausreichend");
        else Console.WriteLine("mangelhaft");
    }

    static void Aufgabe1_For_While()
    {
        Console.Write("Zahl eingeben: ");
        int n1 = int.Parse(Console.ReadLine());

        int sum1 = 0;
        for (int i = 1; i <= n1; i++) sum1 += i;
        Console.WriteLine("Summe (for): " + sum1);

        Console.Write("Zahl eingeben: ");
        int n2 = int.Parse(Console.ReadLine());

        int sum2 = 0;
        int j = 1;

        while (j <= n2)
        {
            sum2 += j;
            j++;
        }

        Console.WriteLine("Summe (while): " + sum2);
    }

    static void Aufgabe2_Multiplikation()
    {
        Console.Write("Zahl eingeben: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        string text = "";

        for (int i = 1; i <= n; i++)
        {
            sum += i;
            text += (i == 1) ? "1" : " + " + i;
        }

        Console.WriteLine("(" + text + ") * 2 = " + (sum * 2));
    }

    static void FarbenAufgabe()
    {
        string[] farben = { "Rot", "Blau", "Grün", "Gelb", "Lila", "Orange", "Schwarz" };

        for (int i = 0; i < farben.Length; i++)
            Console.WriteLine(farben[i]);

        foreach (string f in farben)
            Console.WriteLine(f);
    }

    static void Aufgabe2_Array30()
    {
        Random random = new Random();
        int[] zahlen = new int[30];

        for (int i = 0; i < zahlen.Length; i++)
        {
            zahlen[i] = random.Next(1, 101);
            Console.WriteLine(zahlen[i]);
        }
    }

    // --- Battle Game ---

    static void BattleGame()
    {
        Random random = new Random();

        int heroHealth = 10;
        int monsterHealth = 10;

        do
        {
            int heroAttack = random.Next(1, 11);
            monsterHealth -= heroAttack;
            Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

            if (monsterHealth <= 0)
            {
                Console.WriteLine("Hero wins!");
                break;
            }

            int monsterAttack = random.Next(1, 11);
            heroHealth -= monsterAttack;
            Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");

            if (heroHealth <= 0)
            {
                Console.WriteLine("Monster wins!");
                break;
            }

        } while (heroHealth > 0 && monsterHealth > 0);
    }

    // --- Codeprojekt 1 ---

    static void Codeprojekt1_IntegerValidation()
{
    string? readResult;
    string valueEntered = "";
    int numValue = 0;
    bool validNumber = false;

    Console.WriteLine("Enter an integer value between 5 and 10");

    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            valueEntered = readResult;
        }

        validNumber = int.TryParse(valueEntered, out numValue);

        if (validNumber == true)
        {
            if (numValue <= 5 || numValue >= 10)
            {
                validNumber = false;
                Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
    } while (validNumber == false);

    Console.WriteLine($"Your input value ({numValue}) has been accepted.");
}


    // --- Codeprojekt 2 ---

    static void Codeprojekt2_StringValidation()
{
    string? readResult;
    string roleName = "";
    bool validEntry = false;

    do
    {
        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            roleName = readResult.Trim();
        }

        if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
        {
            validEntry = true;
        }
        else
        {
            Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
        }

    } while (validEntry == false);

    Console.WriteLine($"Your input value ({roleName}) has been accepted.");
}

    // --- Codeprojekt 3 ---

    static void Codeprojekt3_StringArrayProcessing()
{
    string[] myStrings = new string[2]
    {
        "I like pizza. I like roast chicken. I like salad",
        "I like all three of the menu choices"
    };
    int stringsCount = myStrings.Length;

    string myString = "";
    int periodLocation = 0;

    for (int i = 0; i < stringsCount; i++)
    {
        myString = myStrings[i];
        periodLocation = myString.IndexOf(".");

        string mySentence;

        while (periodLocation != -1)
        {
            mySentence = myString.Remove(periodLocation);
            myString = myString.Substring(periodLocation + 1);
            myString = myString.TrimStart();
            periodLocation = myString.IndexOf(".");

            Console.WriteLine(mySentence);
        }

        mySentence = myString.Trim();
        Console.WriteLine(mySentence);
    }
}

    }

