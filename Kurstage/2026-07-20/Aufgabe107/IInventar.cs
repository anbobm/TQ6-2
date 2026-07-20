namespace Aufgabe107;

public interface IInventar
{
    int GetBestand(int id);

    int GetKapazität(int id);

    void UpdateBestand(int id, int anzahl);
}