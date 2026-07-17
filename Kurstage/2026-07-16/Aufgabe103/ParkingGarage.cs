namespace Aufgabe103;

public class ParkingGarage
{
    private int capacity;

    public int FreeSpaces { get; private set; }

    public ParkingGarage(int capacity)
    {
        this.capacity = capacity;
        FreeSpaces = capacity;
    }

    public bool Park()
    {
        if (FreeSpaces <= 0)
        {
            return false;
        }

        FreeSpaces--;

        return true;
    }

    public bool Leave()
    {
        if (FreeSpaces == capacity)
        {
            return false;
        }

        FreeSpaces++;

        return true;
    }
}