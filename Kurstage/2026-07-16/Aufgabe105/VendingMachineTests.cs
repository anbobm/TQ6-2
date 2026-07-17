namespace Aufgabe105;

public class VendingMachineTests
{
    [Fact]
    public void Constructor_SetsCurrentBalanceToZero()
    {
        var machine = new VendingMachine();

        Assert.Equal(0, machine.CurrentBalance);
    }

    [Fact]
    public void InsertMoney_WithOneEuro_IncreasesCurrentBalance()
    {
        var machine = new VendingMachine();

        decimal balance = machine.InsertMoney(1.00m);

        Assert.Equal(1.00m, balance);
        Assert.Equal(1.00m, machine.CurrentBalance);

    }


        [Fact]
    public void InsertMoney_MultiplePayments_AddsAmounts()
    {
        var machine = new VendingMachine();

        machine.InsertMoney(1.00m);
        decimal balance = machine.InsertMoney(2.00m);

        Assert.Equal(3.00m, balance);
        Assert.Equal(3.00m, machine.CurrentBalance);
    }


        [Fact]
    public void InsertMoney_WithZero_ThrowsArgumentException()
    {
        var machine = new VendingMachine();

        Assert.Throws<ArgumentException>(() => machine.InsertMoney(0.00m));
    }

        [Fact]
    public void InsertMoney_WithNegativeAmount_ThrowsArgumentException()
    {
        var machine = new VendingMachine();

        Assert.Throws<ArgumentException>(() => machine.InsertMoney(-1.00m));
    }

        [Fact]
    public void BuyDrink_WithExactAmount_ReturnsTrueAndReducesBalanceToZero()
    {
        var machine = new VendingMachine();
        machine.InsertMoney(2.50m);

        bool success = machine.BuyDrink();

        Assert.True(success);
        Assert.Equal(0.00m, machine.CurrentBalance);
    }

        [Fact]
    public void BuyDrink_WithMoreMoney_ReturnsTrueAndKeepsRestBalance()
    {
        var machine = new VendingMachine();
        machine.InsertMoney(4.20m);

        bool success = machine.BuyDrink();

        Assert.True(success);
        Assert.Equal(1.70m, machine.CurrentBalance);
    }

        [Fact]
    public void BuyDrink_WithNotEnoughMoney_ReturnsFalseAndKeepsBalance()
    {
        var machine = new VendingMachine();
        machine.InsertMoney(1.00m);

        bool success = machine.BuyDrink();

        Assert.False(success);
        Assert.Equal(1.00m, machine.CurrentBalance);
    }

        [Fact]
    

    public void BuyDrink_MultipleDrinks_ReducesBalanceCorrectly()
    {
        var machine = new VendingMachine();
        machine.InsertMoney(5.00m);

        bool firstSuccess = machine.BuyDrink();
        bool secondSuccess = machine.BuyDrink();

        Assert.True(firstSuccess);
        Assert.True(secondSuccess);
        Assert.Equal(0.00m, machine.CurrentBalance);
    }


        [Fact]
    public void ReturnMoney_ReturnsCurrentBalance()
    {
        var machine = new VendingMachine();
        machine.InsertMoney(4.20m);

        decimal returnedMoney = machine.ReturnMoney();

        Assert.Equal(4.20m, returnedMoney);
    }


    [Fact]
    public void ReturnMoney_SetsCurrentBalanceToZero()
    {
        var machine = new VendingMachine();
        machine.InsertMoney(4.20m);

        machine.ReturnMoney();

        Assert.Equal(0.00m, machine.CurrentBalance);
    }



        [Fact]
    public void ReturnMoney_WhenBalanceIsZero_ReturnsZero()
    {
        var machine = new VendingMachine();

        decimal returnedMoney = machine.ReturnMoney();

        Assert.Equal(0.00m, returnedMoney);
        Assert.Equal(0.00m, machine.CurrentBalance);
    }

}