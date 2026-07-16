namespace Aufgabe103;

public class ParkingGarageTests
{
    [Fact]
    public void ParkingGarage_NachInitialisierungFreiePlätze()
    {
        var garage = new ParkingGarage(10);

        Assert.Equal(10, garage.FreeSpaces);
    }

    [Fact]
    public void Park_WithFreeSpacesLeft_ReturnsTrueAndReducesFreeSpaces()
    {
        var garage = new ParkingGarage(10);

        var success = garage.Park();

        Assert.True(success);
        Assert.Equal(9, garage.FreeSpaces);
    }

    [Fact]
    public void Park_NoFreeSpacesLeft_ReturnsFalseAndFreeSpacesRemainsZero()
    {
        var garage = new ParkingGarage(1);
        garage.Park();

        var success = garage.Park();

        Assert.False(success);
        Assert.Equal(0, garage.FreeSpaces);
    }

    [Fact]
    public void Leave_NonEmptyGarageReturnsTrueAndIncreasesFreeSpaces()
    {
        var garage = new ParkingGarage(10);
        garage.Park();

        var success = garage.Leave();

        Assert.True(success);
        Assert.Equal(10, garage.FreeSpaces);
    }

    [Fact]
    public void Leave_EmptyGarageReturnsFalseAndFreeSpacesRemain()
    {
        var garage = new ParkingGarage(10);

        var success = garage.Leave();

        Assert.False(success);
        Assert.Equal(10, garage.FreeSpaces);
    }
}
