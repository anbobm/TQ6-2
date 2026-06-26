using System;

public class Tier
{
    public string Name { get; }

    public Tier(string name)
    {
        Name = name;
    }

    public void SagHallo()
    {
        Console.WriteLine($"Hallo, ich bin {Name}!");
    }
}

public class Hund : Tier
{
    public string Rasse { get; set; }

    public Hund(string name, string rasse) : base(name)
    {
        Rasse = rasse;
    }
}




