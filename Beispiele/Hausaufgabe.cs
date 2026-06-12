int a = 20;
int b = 10;
int c = a * a + b * b;
Console.WriteLine(Math.Sqrt(c));

Console.WriteLine(Math.Min(a, b));


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
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }
        else
        {    
        Console.WriteLine("You rolled doubles! +2 bonus to toal!");
        total += 2;
        }
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

Random Note = new Random();
int number = Note.Next(1, 101);

if (number >= 80)
{
    Console.WriteLine("Sehr gut!");
}
else if (number >= 60)
{
    Console.WriteLine("Gut!");
}
else if (number >= 40)
{
    Console.WriteLine("Befriedigend!");
}
else if (number >= 20)
{
    Console.WriteLine("Ausreichend!");
}
else
{
    Console.WriteLine("Ungenügend!");
}

