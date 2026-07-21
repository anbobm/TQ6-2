namespace Aufgabe108;

public class JackenBerater
{
    public bool JackeAnziehen(int grenzwert, IWetterApi wetter)
    {
        int temperatur = wetter.TemperaturCelsius();

        return temperatur < grenzwert;
    }
}