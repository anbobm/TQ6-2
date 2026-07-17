namespace Aufgabe103;

public class ParkingGarageTests
{
    [Fact]
    public void Constructor_SetsFreeSpacesToCapacity()
    {
        var garage = new ParkingGarage(3);

        Assert.Equal(3, garage.FreeSpaces);
    }

    [Fact]
    public void Park_WithFreeSpacesLeft_ReturnsTrueAndReducesFreeSpaces()
    {
        var garage = new ParkingGarage(3);

        bool success = garage.Park();

        Assert.True(success);
        Assert.Equal(2, garage.FreeSpaces);
    }

    [Fact]
    public void Park_WhenGarageIsFull_ReturnsFalseAndKeepsFreeSpaces()
    {
        var garage = new ParkingGarage(0);

        bool success = garage.Park();

        Assert.False(success);
        Assert.Equal(0, garage.FreeSpaces);
    }

    [Fact]
    public void Leave_WithParkedCars_ReturnsTrueAndIncreasesFreeSpaces()
    {
        var garage = new ParkingGarage(3);
        garage.Park();

        bool success = garage.Leave();

        Assert.True(success);
        Assert.Equal(3, garage.FreeSpaces);
    }



      [Fact]
    public void Leave_WhenGarageIsEmpty_ReturnsFalseAndKeepsFreeSpaces()
    {
        var garage = new ParkingGarage(3);

        bool success = garage.Leave();

        Assert.False(success);
        Assert.Equal(3, garage.FreeSpaces);
    }
}