// Erstelle eine Klasse `Mitarbeiter` mit privaten Attributen für den Namen und das Gehalt, die der Konstruktor als Parameter erwartet.

// #### Methoden:

// * `GetGehalt()` gibt das Gehalt zurück
// * `GehaltErhoehen(prozent)` erhöht das Gehalt um `prozent`. Nur positive Werte sind zugelassen.

// Erstelle nun eine Klasse `Manager`. Ein Manager *ist* ein Mitarbeiter, die Klasse `Manager` soll also von der Klasse `Mitarbeiter` erben.

// Darüber hinaus hat die Klasse `Manager` ein privates Attribut für den Bonus, welcher als Parameter im Konstruktor erwartet wird.

// #### Methoden:

// * Die Methode `GetGehalt()` der Basisklasse wird überschrieben und berücksichtigt jetzt auch den zusätzlichen Bonus des Managers (Gehalt + Bonus).
// * `SetBonus(bonus)` setzt den Bonus auf den Wert `bonus`. Negative Werte sind nicht erlaubt.

public class Mitarbeiter
{
    public string Name { get; }

    protected decimal gehalt;
    
    public Mitarbeiter(string name, decimal gehalt)
    {
        Name = name;
        this.gehalt = gehalt;
    }

    public void GehaltErhoehen(decimal prozent)
    {
        gehalt = gehalt + gehalt * prozent / 100;
    }

    public virtual decimal GetGehalt()
    {
        return gehalt;
    }
}

public class Manager : Mitarbeiter
{
    public decimal Bonus
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Bonus kann nicht negativ sein");
            }
            field = value;
        }
    }

    public Manager(string name, decimal gehalt, decimal bonus) : base(name, gehalt)
    {
        Bonus = bonus;
    }

    public override decimal GetGehalt()
    {
        return gehalt + Bonus;
    }
}