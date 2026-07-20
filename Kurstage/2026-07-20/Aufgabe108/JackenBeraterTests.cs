using Moq;

namespace Aufgabe108;

public class JackenBeraterTests
{
    [Fact]
    public void JackeAnziehen_TemperaturGleichGrenzwertReturnsFalse()
    {
        var berater = new JackenBerater();
        var mockApi = new Mock<IWetterApi>();
        mockApi.Setup(m => m.TemperaturCelsius()).Returns(20);

        var result = berater.JackeAnziehen(20, mockApi.Object);

        Assert.False(result);
    }

    [Fact]
    public void JackeAnziehen_TemperaturKleinerGrenzwertReturnsTrue()
    {
        var berater = new JackenBerater();
        var mockApi = new Mock<IWetterApi>();
        mockApi.Setup(m => m.TemperaturCelsius()).Returns(19);

        var result = berater.JackeAnziehen(20, mockApi.Object);

        Assert.True(result);
    }
}
