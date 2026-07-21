using Moq;

namespace MockBeispiel;

public class Tests
{
    [Fact]
    public void AbteilungHinzufügen_LoggtMeldung()
    {
        var mockLogger = new Mock<ILogger>();
        var unternehmen = new Unternehmen("Foo", mockLogger.Object);

        unternehmen.AbteilungHinzufügen(new Abteilung("Testabteilung", null!));

       mockLogger.Verify(logger => logger.Log("Abteilung Testabteilung wurde zum Unternehmen Foo hinzugefügt."), Times.Once);
    }

    [Fact]
    public void BestellungBezahlen_RabattWirdVonGesamtpreisAbgezogen()
    {
        var mockBezahlung = new Mock<IBezahlung>();
        var mockRabatt = new Mock<IRabatt>();
        mockRabatt.Setup(rabatt => rabatt.RabattBerechnen(It.IsAny<decimal>())).Returns(10);
        var bestellung = new Bestellung("Kunde");
        bestellung.ArtikelHinzufügen("Artikel", 100);

        bestellung.BestellungBezahlen(mockBezahlung.Object, mockRabatt.Object);

        mockBezahlung.Verify(bezahlung => bezahlung.Bezahlen(90), Times.Once);
    }
}