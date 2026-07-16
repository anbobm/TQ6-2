var logger = new FileLogger();
var bezahlung = new BarBezahlung();
var rabatt = new StudentenRabatt();

var bestellung1 = new Bestellung("Tunahan", logger);
bestellung1.ArtikelHinzufügen("Klimaanlage", 1000.00m);
bestellung1.BestellungBezahlen(bezahlung, rabatt);

var artikel = new List<(string Name, decimal Stückpreis)>
{
    ("Fußball (gebraucht)", 9.99m),
    ("Trinkflasche", 5.00m)
};

var bestellung2 = new Bestellung("Max Mustermann", artikel, logger);
bestellung2.BestellungBezahlen(bezahlung, rabatt);
