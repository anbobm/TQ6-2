public class JackenBerater
{
    public bool JackeAnziehen(int grenzwert, IWetterApi wetter)
    {
        var temperatur = wetter.TemperaturCelsius();

        return temperatur < grenzwert;
    }
}

public interface IWetterApi
{
    int TemperaturCelsius();
}

public class WetterOnline : IWetterApi
{
    public int TemperaturCelsius()
    {
        // HTTP-Request zu WetterOnline API
        throw new NotImplementedException();
    }
}