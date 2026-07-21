//Aufgabe 1
//Erstelle eine Klasse Auto mit den Attributen Marke, Modell und Baujahr und einer Methode DisplayInfo(), die diese formatiert ausgibt.
//Erstelle mit new ein paar Objekte dieser Klasse und teste die DisplayInfo()-Methode.

using System;
using System.Collections.Generic;

namespace Aufgaben
{
    class Auto
    {
        public string Marke;
        public string Modell;
        public int Baujahr;

        public void DisplayInfo()
        {
            Console.WriteLine($"Marke: {Marke}");
            Console.WriteLine($"Modell: {Modell}");
            Console.WriteLine($"Baujahr: {Baujahr}");
        }
    }

    internal class Program
    {
        internal static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            auto1.Marke = "BMW";
            auto1.Modell = "3er";
            auto1.Baujahr = 2012;

            Auto auto2 = new Auto();
            auto2.Marke = "Opel";
            auto2.Modell = "Corsa";
            auto2.Baujahr = 2015;


            auto1.DisplayInfo();
            auto2.DisplayInfo();
        }    
    }
}

//Aufgabe 2: Kapselung
//Setze die Attribute jetzt private und schreibe Getter und Setter zum Auslesen und Setzen der Werte: GetMarke(), SetMarke(marke), etc.
//Baujahr soll nicht kleiner als 1880 sein.

using System;
using System.Collections.Generic;

namespace Aufgaben
{
    class Auto
    {
        private string _Marke;
        private string _Modell;
        private int _Baujahr;

        public string GetMarke()
        {
            return _Marke;
        }

        public void SetMarke(string Marke)
        {
            this._Marke = Marke;
        }

        public string GetModell()
        {
            return _Modell;
        }

        public void SetModell(string Modell)
        {
            this._Modell = Modell;
        }

        public int GetBaujahr()
        {
            return _Baujahr;
        }

        public void SetBaujahr(int Baujahr)
        {
            if(Baujahr < 1880)
            {
                throw new ArgumentException("Baujahr soll grosser als 1880 sein!");
            }
            else
            {
                this._Baujahr = Baujahr;
            }        
        }

        public void DisplayInfo()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"Marke: {_Marke}");
            Console.WriteLine($"Modell: {_Modell}");
            Console.WriteLine($"Baujahr: {_Baujahr}");         
        }
    }

    internal class Program
    {
        internal static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            auto1.SetMarke("BMW");
            auto1.SetModell("3er");
            auto1.SetBaujahr(1881);

            Auto auto2 = new Auto();
            auto2.SetMarke("Opel");
            auto2.SetModell("Corsa");
            auto2.SetBaujahr(2016);


            auto1.DisplayInfo();
            auto2.DisplayInfo();
        }    
    }
}

//Aufgabe 3: Properties
//Der Zugriff über Getter und Setter kann recht umständlich sein, daher gibt es die Möglichkeit stattdessen Properties zu verwenden.
//Diese verhalten sich nach außen wie öffentliche Felder, können aber getter- und setter-Funktionalität implementieren.
//Schreibe die Getter und Setter für die drei Attribute von Auto in Properties um.
//Marke darf nur auf BMW, Opel oder Trabant gesetzt werden. Wenn die Marke gesetzt wird, wird das Modell auf ein konkretes Modell gesetzt, welches zu dieser Marke gehört.
//Zulässige Werte für Modell, je nach gesetzter Marke:
//BMW: "3er", "5er", "7er"
//Opel: "Corsa", "Astra", "Adam"
//Trabant: "P 50", "P 60", "P 601", "1.1"
//Das Baujahr darf weiterhin nur Werte >= 1880 enthalten.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgaben
{
    class Auto
    {
        Random random = new Random();

        private string _Marke;
        private string _Modell;
        private int _Baujahr;

        Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>
        {
            {"BMW", new List<string>{"3er", "5er", "7er"} },
            {"Opel", new List<string>{"Corsa", "Astra", "Adam"} },
            {"Trabant", new List<string>{"P 50", "P 60", "P 601", "1.1"} }
        };

        public string Marke
        {       
            set
            {
                if(keyValuePairs.ContainsKey(value))
                {
                    _Marke = value;
                }
                else
                {
                    Console.WriteLine("Ungueltige Schluessel. Probieren Sie noch mal.");
                }
            }
            get 
            { 
                return _Marke; 
            }
        }

        public string Modell
        {
            get { return _Modell; }

            set
            {
                if (_Marke == null)
                {
                    Console.WriteLine("Zuerst Marke setzen!");
                    return;
                }

                List<string> modelle = keyValuePairs[_Marke];

                _Modell = modelle[random.Next(modelle.Count)];
            }
        }
        public int Baujahr
        {
            set
            {
                if(value > 1880)
                {
                    _Baujahr = value;
                }
                else
                {
                    Console.WriteLine("Baujahr darf kleiner als 1880j nicht sein.");
                }
            }
            get
            {
                return _Baujahr;
            }
        }
    }

    internal class Program
    {
        internal static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Marke = "BMW";
            auto.Modell = "";
            Console.WriteLine(auto.Marke + " " + auto.Modell);
        }    
    }
}

//Aufgabe 4: Konstruktor
//Ergänze einen passenden Konstruktor in der Auto-Klasse, der die Attribute mit den übergebenen Parametern initialisiert.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgaben
{
    class Auto
    {
        Random random = new Random();

        private string _Marke;
        private string _Modell;
        private int _Baujahr;

        public Auto(string marke, string modell, int baujahr)
        {
            Marke = marke;
            Modell = modell;
            Baujahr = baujahr;       
        }

        Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>
        {
            {"BMW", new List<string>{"3er", "5er", "7er"} },
            {"Opel", new List<string>{"Corsa", "Astra", "Adam"} },
            {"Trabant", new List<string>{"P 50", "P 60", "P 601", "1.1"} }
        };

        public string Marke
        {       
            set
            {
                if(keyValuePairs.ContainsKey(value))
                {
                    _Marke = value;
                }
                else
                {
                    Console.WriteLine("Ungueltige Schluessel. Probieren Sie noch mal.");
                }
            }
            get 
            { 
                return _Marke; 
            }
        }

        public string Modell
        {
            get { return _Modell; }

            set
            {
                if (_Marke == null)
                {
                    Console.WriteLine("Zuerst Marke setzen!");
                    return;
                }

                List<string> modelle = keyValuePairs[_Marke];

                _Modell = modelle[random.Next(modelle.Count)];
            }
        }
        public int Baujahr
        {
            set
            {
                if(value > 1880)
                {
                    _Baujahr = value;
                }
                else
                {
                    Console.WriteLine("Baujahr darf kleiner als 1880j nicht sein.");
                }
            }
            get
            {
                return _Baujahr;
            }
        }
    }

    internal class Program
    {
        internal static void Main(string[] args)
        {
            Auto auto = new Auto("BMW"," ", 2012);

            Console.WriteLine("Marke: " + auto.Marke + "; Modell: " + auto.Modell + "; Baujahr: " + auto.Baujahr);
        }    
    }
}

//Aufgabe 5
//Schreibe eine Klasse Cabrio die von Auto erbt. Diese Klasse soll eine Property IsVerdeckOffen (bool) besitzen, 
//die festhält, ob das Verdeck geöffnet ist oder nicht. Außerdem überschreibt (override) die Klasse die DisplayInfo()-Methode 
//(dazu muss in der Basisklasse Auto die Methode noch als virtual deklariert werden).

public class Cabrio : Auto
{
    private bool _IsVerdeckOffen = false;
    public Cabrio(string marke, string modell, int baujahr, bool _IsVerdeckOffen) 
        : base(marke, modell, baujahr)
    {
        this._IsVerdeckOffen = _IsVerdeckOffen;
    }
    public bool IsVerdeckOffen
    {
        set
        {
            _IsVerdeckOffen = value;
        }
        get
        {
            return _IsVerdeckOffen;
        }
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Is Verdeck offen?: {IsVerdeckOffen}");
    }
}

//Aufgabe 6
//Die Klasse Auto soll eine Basisklasse namens Fahrzeug bekommen, und diese soll abstract sein. 
//In ihr soll es eine abstrakte Methode Fahren() geben. Diese soll eine passende Ausgabe in der Kommandozeile erzeugen.

public abstract class Fahrzeug
{
    public abstract void Fahren();
}

public override void Fahren()
{
    Console.WriteLine($"Das Auto fahrt.");
}

//Aufgabe 7
//Schreibe eine Klasse LKW die von Fahrzeug erbt. 
//Es soll eine Property Beladung (int in kg) und eine nur lesbare Property (private set) MaximaleBeladung (int in kg) geben, 
//letztere wird dem Konstruktor übergeben. Die Beladung darf sich nur im Bereich zwischen 0 und MaximaleBeladung bewegen.

public class LKW : Fahrzeug
{
    private int beladung;
    public int Beladung
    {
        get { return beladung; }
        set
        {
            if (value >= 0 && value <= MaximaleBeladung)
            {
                beladung = value;
            }
        }
    }

    public int MaximaleBeladung { get; private set; }

    public LKW(int maximaleBeladung)
    {
        MaximaleBeladung = maximaleBeladung;
        Beladung = 0;
    }

    public override void Fahren()
    {
        Console.WriteLine("Der LKW fährt.");
    }
}
