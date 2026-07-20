namespace Aufgabe107;

public class Lager
{
    private IInventar inventar;

    public Lager(IInventar inventar)
    {
        this.inventar = inventar;
    }

   public bool Verkaufen(int id, int anzahl)
{
    int bestand = inventar.GetBestand(id);

    if (bestand < anzahl)
    {
        return false;
    }

    inventar.UpdateBestand(id, bestand - anzahl);
    return true;
}

    public bool Nachbestellen(int id, int anzahl)
    {
        throw new NotImplementedException();
    }
}