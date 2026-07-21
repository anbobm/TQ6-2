//Aufgabe 1 – Produkt

using System;

public class Produkt
{
    private string _name;
    private double _preis;
    private int _lagerbestand;

    public Produkt(string name, double preis)
    {
        _name = name;
        _preis = preis;
        _lagerbestand = 0;
    }

    public void Verkaufen(int menge)
    {
        if (menge > 0 && menge <= _lagerbestand)
        {
            _lagerbestand -= menge;
        }
    }

    public void Nachbestellen(int menge)
    {
        if (menge > 0)
        {
            _lagerbestand += menge;
        }
    }

    public void SetPreis(double neuerPreis)
    {
        if (neuerPreis >= 0)
        {
            _preis = neuerPreis;
        }
    }

    public string GetInfo()
    {
        return $"Name: {_name}, Preis: {_preis}€, Lagerbestand: {_lagerbestand}";
    }
}

//Aufgabe 2

using System;

public class Rechteck
{
    private double _breite;
    private double _hoehe;

    public Rechteck(double breite, double hoehe)
    {
        if (breite > 0)
            _breite = breite;

        if (hoehe > 0)
            _hoehe = hoehe;
    }

    public void SetBreite(double wert)
    {
        if (wert > 0)
        {
            _breite = wert;
        }
    }

    public void SetHoehe(double wert)
    {
        if (wert > 0)
        {
            _hoehe = wert;
        }
    }

    public double Flaeche()
    {
        return _breite * _hoehe;
    }

    public double Umfang()
    {
        return 2 * (_breite + _hoehe);
    }
}

//Aufgabe 3

using System;

public class Benutzer
{
    private string _benutzername;
    private string _passwort;
    private bool _istEingeloggt;

    public Benutzer(string benutzername, string passwort)
    {
        _benutzername = benutzername;
        _passwort = passwort;
        _istEingeloggt = false;
    }

    public void Login(string passwort)
    {
        if (passwort == _passwort)
        {
            _istEingeloggt = true;
        }
    }

    public void Logout()
    {
        _istEingeloggt = false;
    }

    public void PasswortAendern(string altesPw, string neuesPw)
    {
        if (altesPw == _passwort && neuesPw.Length >= 8)
        {
            _passwort = neuesPw;
        }
    }

    public bool Eingeloggt()
    {
        return _istEingeloggt;
    }
}


//Aufgabe 4

using System;

public class Temperatursensor
{
    private double _celsius;

    public Temperatursensor()
    {
        _celsius = 0;
    }

    public void SetCelsius(double wert)
    {
        if (wert >= -273.15)
        {
            _celsius = wert;
        }
    }

    public double GetCelsius()
    {
        return _celsius;
    }

    public double GetFahrenheit()
    {
        return _celsius * 9 / 5 + 32;
    }

    public void Erhoehen(double wert)
    {
        _celsius += wert;
    }

    public void Senken(double wert)
    {
        if (_celsius - wert >= -273.15)
        {
            _celsius -= wert;
        }
        else
        {
            _celsius = -273.15;
        }
    }
}


//Aufgabe 5

using System;

public class Mitarbeiter
{
    private string _name;
    protected double _gehalt;

    public Mitarbeiter(string name, double gehalt)
    {
        _name = name;
        _gehalt = gehalt;
    }

    public virtual double GetGehalt()
    {
        return _gehalt;
    }

    public void GehaltErhoehen(double prozent)
    {
        if (prozent > 0)
        {
            _gehalt += _gehalt * prozent / 100;
        }
    }
}

public class Manager : Mitarbeiter
{
    private double _bonus;

    public Manager(string name, double gehalt, double bonus)
        : base(name, gehalt)
    {
        if (bonus >= 0)
        {
            _bonus = bonus;
        }
    }

    public override double GetGehalt()
    {
        return _gehalt + _bonus;
    }

    public void SetBonus(double bonus)
    {
        if (bonus >= 0)
        {
            _bonus = bonus;
        }
    }
}