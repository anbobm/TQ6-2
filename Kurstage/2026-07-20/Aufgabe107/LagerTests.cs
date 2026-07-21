using Moq;

namespace Aufgabe107;

public class LagerTests
{
    [Fact]
    public void Verkaufen_GenügendArtikelVorhandenBestandWirdAktualisert()
    {
        var mockInventar = new Mock<IInventar>();
        mockInventar.Setup(i => i.GetBestand(123)).Returns(15);
        var lager = new Lager(mockInventar.Object);

        lager.Verkaufen(123, 10);

        mockInventar.Verify(i => i.GetBestand(123), Times.Once);
        mockInventar.Verify(i => i.UpdateBestand(123, 5), Times.Once);
    }

    [Fact]
    public void Verkaufen_GenügendArtikelVorhandenGibtTrueZurück()
    {
        var mockInventar = new Mock<IInventar>();
        mockInventar.Setup(i => i.GetBestand(123)).Returns(15);
        var lager = new Lager(mockInventar.Object);

        var result = lager.Verkaufen(123, 10);

        Assert.True(result);
    }

    [Fact]
    public void Verkaufen_NichtGenügendArtikelVorhandenBestandWirdNichtAktualisert()
    {
        var mockInventar = new Mock<IInventar>();
        mockInventar.Setup(i => i.GetBestand(123)).Returns(15);
        var lager = new Lager(mockInventar.Object);

        lager.Verkaufen(123, 20);

        mockInventar.Verify(i => i.GetBestand(123), Times.Once);
        mockInventar.Verify(i => i.UpdateBestand(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
    }

    [Fact]
    public void Verkaufen_NichtGenügendArtikelVorhandenGibtFalseZurück()
    {
        var mockInventar = new Mock<IInventar>();
        mockInventar.Setup(i => i.GetBestand(123)).Returns(15);
        var lager = new Lager(mockInventar.Object);

        var result = lager.Verkaufen(123, 20);

        Assert.False(result);
    }

    [Fact]
    public void Nachbestellen_GesamtmengeNichtGrößerAlsKapazitätErhöhtMenge()
    {
        var mockInventar = new Mock<IInventar>();
        mockInventar.Setup(i => i.GetBestand(123)).Returns(10);
        mockInventar.Setup(i => i.GetKapazität(123)).Returns(20);
        var lager = new Lager(mockInventar.Object);

        lager.Nachbestellen(123, 10);

        mockInventar.Verify(i => i.GetBestand(123), Times.Once);
        mockInventar.Verify(i => i.GetKapazität(123), Times.Once);
        mockInventar.Verify(i => i.UpdateBestand(123, 20));
    }

    [Fact]
    public void Nachbestellen_GesamtmengeNichtGrößerAlsKapazitätGibtTrueZurück()
    {
        var mockInventar = new Mock<IInventar>();
        mockInventar.Setup(i => i.GetBestand(123)).Returns(10);
        mockInventar.Setup(i => i.GetKapazität(123)).Returns(20);
        var lager = new Lager(mockInventar.Object);

        var result = lager.Nachbestellen(123, 10);

        Assert.True(result);
    }

    [Fact]
    public void Nachbestellen_GesamtmengeGrößerAlsKapazitätErhöhtMengeNicht()
    {
        var mockInventar = new Mock<IInventar>();
        mockInventar.Setup(i => i.GetBestand(123)).Returns(10);
        mockInventar.Setup(i => i.GetKapazität(123)).Returns(20);
        var lager = new Lager(mockInventar.Object);

        lager.Nachbestellen(123, 11);

        mockInventar.Verify(i => i.GetBestand(123), Times.Once);
        mockInventar.Verify(i => i.GetKapazität(123), Times.Once);
        mockInventar.Verify(i => i.UpdateBestand(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
    }

    [Fact]
    public void Nachbestellen_GesamtmengeGrößerAlsKapazitätGibtFalseZurück()
    {
        var mockInventar = new Mock<IInventar>();
        mockInventar.Setup(i => i.GetBestand(123)).Returns(10);
        mockInventar.Setup(i => i.GetKapazität(123)).Returns(20);
        var lager = new Lager(mockInventar.Object);

        var result = lager.Nachbestellen(123, 11);

        Assert.False(result);
    }
}
