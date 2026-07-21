var logger = new FileLogger();
var bezahlung = new BarBezahlung();
var rabatt = new StudentenRabatt();

var bestellung1 = new Bestellung("Tunahan", logger);
bestellung1.ArtikelHinzufügen("Klimaanlage", 1000.00m);
bestellung1.BestellungBezahlen(bezahlung, rabatt);

var bestellung2 = new Bestellung("Max Mustermann", logger);
bestellung2.ArtikelHinzufügen("Fußball (gebraucht)", 9.99m);
bestellung2.BestellungBezahlen(bezahlung, rabatt);