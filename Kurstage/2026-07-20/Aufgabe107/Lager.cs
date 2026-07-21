public class Lager
{
    private IInventar inventar;

    public Lager(IInventar inventar)
    {
        this.inventar = inventar;
    }

    public bool Verkaufen(int id, int anzahl)
    {
        var bestand = inventar.GetBestand(id);

        if (bestand < anzahl)
        {
            return false;
        }

        inventar.UpdateBestand(id, bestand - anzahl);

        return true;
    }

    public bool Nachbestellen(int id, int anzahl)
    {
        var bestand = inventar.GetBestand(id);
        var kapazität = inventar.GetKapazität(id);

        var gesamt = bestand + anzahl;

        if(gesamt > kapazität)
        {
            return false;
        }

        inventar.UpdateBestand(id, gesamt);

        return true;
    }
}

public interface IInventar
{
    int GetBestand(int id);

    int GetKapazität(int id);

    void UpdateBestand(int id, int anzahl);
}

public class Inventar : IInventar
{
    public int GetBestand(int id)
    {
        // Datenbankabfrage an SQL-DB
        return 0;
    }

    public int GetKapazität(int id)
    {
        // Datenbankabfrage an SQL-DB
        return 0;
    }

    public void UpdateBestand(int id, int anzahl)
    {
        // Datenbankabfrage an SQL-DB
    }
}