var bestellung = new Bestellung("Tunahan");
bestellung.ArtikelHinzufügen("Klimaanlage", 1499.90m);
bestellung.ArtikelHinzufügen("Eismaschine", 49.99m);
bestellung.ArtikelHinzufügen("gekühlter Apfel", 0.79m);
bestellung.Artikel.Add(("Duschgel", 1.99m));

var bezahlung1 = new BarBezahlung();
var bezahlung2 = new KreditkartenBezahlung();
var bezahlung3 = new PayPalBezahlung();

// BestellungBezahlen erwartet nur das Interface IBezahlung
// Alle Objekte, die dieses implementieren, können benutzt werden.
// Die Bestellungsklasse interessiert sich nicht für die
// konkrete Implementierung.
bestellung.BestellungBezahlen(bezahlung1);
bestellung.BestellungBezahlen(bezahlung2);
bestellung.BestellungBezahlen(bezahlung3);
