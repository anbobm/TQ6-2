namespace BeispielTests;

public class TemperatursensorTests
{
    [Fact]
    public void Erhoehen_TemperaturUmWertErhoehenErfolgreich()
    {
        // Arrange
        var sensor = new Temperatursensor();

        // Act
        sensor.Erhoehen(100);

        // Assert
        Assert.Equal(100, sensor.TemperaturCelsius);
    }

    [Fact]
    public void Senken_TemperaturUmWertSenkenErfolgreich()
    {
        var sensor = new Temperatursensor();

        sensor.Senken(50);

        Assert.Equal(-50, sensor.TemperaturCelsius);
    }

    [Fact]
    public void Senken_TemperaturUnterAbsoluterNullpunktWirftException()
    {
        var sensor = new Temperatursensor();

        Assert.Throws<ArgumentException>(() => sensor.Senken(273.151m));
    }

    [Fact]
    public void TemperaturFahrenheit()
    {
        var sensor = new Temperatursensor();

        sensor.TemperaturCelsius = 0;
        Assert.Equal(32, sensor.TemperaturFahrenheit);

        sensor.TemperaturCelsius = 100;
        Assert.Equal(212, sensor.TemperaturFahrenheit);
    }
}
