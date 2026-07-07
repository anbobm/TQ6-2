// # Aufgabe 4

// Erstelle eine Klasse `Temperatursensor`.

// Sie hat ein privates **Attribut** für die aktuelle Temperatur (in Celsius), die zu Anfang auf 0 gesetzt wird.

// #### Methoden:

// * `SetCelsius(wert)`: Setzt die Temperatur auf den übergebenen Wert.
// * `GetCelsius()`: Gibt die Temperatur in Celsius zurück
// *  `GetFahrenheit()`: Gibt die Temperatur in [Fahrenheit](https://www.analytics-shop.com/de/umrechnen-celsius-in-fahrenheit) zurück
// * `Erhoehen(wert)`: Erhöht die Temperatur um den übergebenen Wert
// * `Senken(wert)`: Senkt die Temperatur um den übergebenen Wert. 

// **Hinweis**: Die Temperatur darf nie kleiner als `-273.15` sein.

public class Temperatursensor
{
    public decimal TemperaturCelsius
    {
        get;
        set
        {
            if (value < -273.15m)
            {
                throw new ArgumentException("Temperatur darf kann kälter als -273.15 °C");
            }
            field = value;
        }
    }

    public decimal TemperaturFahrenheit => TemperaturCelsius * 1.8m + 32m;

    public void Erhoehen(decimal betrag)
    {
        TemperaturCelsius += betrag;
    }

    public void Senken(decimal betrag)
    {
        TemperaturCelsius -= betrag;
    }
}