var bestellung = new Bestellung("Tunahan");
bestellung.ArtikelHinzufügen("Klimaanlage", 1000.00m);

var bezahlung = new BarBezahlung();

var rabatt1 = new KeinRabatt();
var rabatt2 = new StudentenRabatt();
var rabatt3 = new SeniorenRabatt();

// BestellungBezahlen erwartet nur das Interface IRabatt.
// Alle Objekte, die dieses implementieren, können benutzt werden.
// Die Bestellungsklasse interessiert sich nicht für die
// konkrete Implementierung.
bestellung.BestellungBezahlen(bezahlung, rabatt1);
bestellung.BestellungBezahlen(bezahlung, rabatt2);
bestellung.BestellungBezahlen(bezahlung, rabatt3);
