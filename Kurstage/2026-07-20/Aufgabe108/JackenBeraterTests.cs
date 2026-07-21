using Moq;

namespace Aufgabe108;

public class JackenBeraterTests
{
    [Fact]
    public void JackeAnziehen_WhenTemperatureIsLowerThanGrenzwert_ReturnsTrue()
    {
        var mockWetter = new Mock<IWetterApi>();
        mockWetter.Setup(wetter => wetter.TemperaturCelsius()).Returns(15);
        var berater = new JackenBerater();

        var result = berater.JackeAnziehen(20, mockWetter.Object);

        Assert.True(result);
    }


        [Fact]
    public void JackeAnziehen_WhenTemperatureIsEqualToGrenzwert_ReturnsFalse()
    {
        var mockWetter = new Mock<IWetterApi>();
        mockWetter.Setup(wetter => wetter.TemperaturCelsius()).Returns(20);
        var berater = new JackenBerater();

        var result = berater.JackeAnziehen(20, mockWetter.Object);

        Assert.False(result);
    }


        [Fact]
    public void JackeAnziehen_WhenTemperatureIsHigherThanGrenzwert_ReturnsFalse()
    {
        var mockWetter = new Mock<IWetterApi>();
        mockWetter.Setup(wetter => wetter.TemperaturCelsius()).Returns(25);
        var berater = new JackenBerater();

        var result = berater.JackeAnziehen(20, mockWetter.Object);

        Assert.False(result);
    }

}