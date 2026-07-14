ILogger logger = new FileLogger();

var unternehmen = new Unternehmen("Print GmbH", logger);

var entwicklung = new Abteilung("Entwicklung", logger);
var vertrieb = new Abteilung("Vertrieb", logger);
var produktion = new Abteilung("Produktion", logger);
var buchhaltung = new Abteilung("Buchhaltung", logger);

Abteilung[] abteilungen = [entwicklung, vertrieb, produktion, buchhaltung];

foreach (var abteilung in abteilungen)
{
    unternehmen.AbteilungHinzufügen(abteilung);
}

produktion.MitarbeiterHinzufügen(unternehmen.MitarbeiterErzeugen("001", "Tunahan"));
produktion.MitarbeiterHinzufügen(unternehmen.MitarbeiterErzeugen("002", "Anne"));
produktion.MitarbeiterHinzufügen(unternehmen.MitarbeiterErzeugen("003", "Katja"));
produktion.MitarbeiterHinzufügen(unternehmen.MitarbeiterErzeugen("004", "Mohamad"));
produktion.MitarbeiterHinzufügen(unternehmen.MitarbeiterErzeugen("005", "Sebastian"));
produktion.MitarbeiterHinzufügen(unternehmen.MitarbeiterErzeugen("006", "Ihor"));
entwicklung.MitarbeiterHinzufügen(unternehmen.MitarbeiterErzeugen("007", "Ruwen"));
vertrieb.MitarbeiterHinzufügen(unternehmen.MitarbeiterErzeugen("008", "Nataliya"));
buchhaltung.MitarbeiterHinzufügen(unternehmen.MitarbeiterErzeugen("009", "Andreas"));
buchhaltung.MitarbeiterHinzufügen(unternehmen.MitarbeiterErzeugen("010", "Efkan"));

unternehmen.Info();