using Moq;

namespace Aufgabe107;

public class LagerTests
{
    [Fact]
    public void Verkaufen_WhenEnoughArticlesAvailable_ReturnsTrueAndReducesBestand()
    {
        var mockInventar = new Mock<IInventar>();
        mockInventar.Setup(inventar => inventar.GetBestand(1)).Returns(10);
        var lager = new Lager(mockInventar.Object);

        var result = lager.Verkaufen(1, 3);

        Assert.True(result);
        mockInventar.Verify(inventar => inventar.UpdateBestand(1, 7), Times.Once);
    }
}