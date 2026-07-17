namespace Aufgabe105;

public class VendingMachineTests
{
    [Fact]
    public void VendingMachine_CurrentBalanceBeginsAtZero()
    {
        var vendingMachine = new VendingMachine();

        Assert.Equal(0, vendingMachine.CurrentBalance);
    }

    [Fact]
    public void InsertMoney_AddingMoneyRaisesBalance()
    {
        var vendingMachine = new VendingMachine();

        vendingMachine.InsertMoney(1.00m);

        Assert.Equal(1.00m, vendingMachine.CurrentBalance);
    }

    [Fact]
    public void InsertMoney_AddingMoneyMultipleTimesRaisesBalance()
    {
        var vendingMachine = new VendingMachine();

        vendingMachine.InsertMoney(1.00m);
        vendingMachine.InsertMoney(1.00m);

        Assert.Equal(2.00m, vendingMachine.CurrentBalance);
    }

    [Fact]
    public void InsertMoney_InsertingZeroThrows()
    {
        var vendingMachine = new VendingMachine();

        Assert.Throws<ArgumentException>(() => vendingMachine.InsertMoney(0));
    }

    [Fact]
    public void InsertMoney_InsertingNegativeAmountThrows()
    {
        var vendingMachine = new VendingMachine();

        Assert.Throws<ArgumentException>(() => vendingMachine.InsertMoney(-1));
    }

    [Fact]
    public void BuyDrink_BalanceMatchesDrinkPriceReturnsTrue()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InsertMoney(2.5m);

        var result = vendingMachine.BuyDrink();

        Assert.True(result);
    }

    [Fact]
    public void BuyDrink_BalanceHigherThanDrinkPriceReturnsTrue()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InsertMoney(3m);

        var result = vendingMachine.BuyDrink();

        Assert.True(result);
    }

    [Fact]
    public void BuyDrink_BalanceLowerThanDrinkPriceReturnsTrue()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InsertMoney(2m);

        var result = vendingMachine.BuyDrink();

        Assert.False(result);
    }

    [Fact]
    public void BuyDrink_BalanceDecreasesAfterSuccessfulPurchase()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InsertMoney(3m);

        vendingMachine.BuyDrink();

        Assert.Equal(0.5m, vendingMachine.CurrentBalance);
    }

    [Fact]
    public void BuyDrink_BuyingMultipleDrinks()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InsertMoney(6m);

        var result = vendingMachine.BuyDrink();
        Assert.True(result);
        result = vendingMachine.BuyDrink();
        Assert.True(result);
        result = vendingMachine.BuyDrink();
        Assert.False(result);
        Assert.Equal(1, vendingMachine.CurrentBalance);
    }

    [Fact]
    public void ReturnMoney_ReturnsRemainingBalance()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InsertMoney(10);

        var result = vendingMachine.ReturnMoney();

        Assert.Equal(10, result);
    }

    [Fact]
    public void ReturnMoney_RemainingBalanceIsZeroAfter()
    {
        var vendingMachine = new VendingMachine();
        vendingMachine.InsertMoney(10);

        vendingMachine.ReturnMoney();

        Assert.Equal(0, vendingMachine.CurrentBalance);
    }

    [Fact]
    public void ReturnMoney_ReturnsZeroWhenZeroBalance()
    {
        var vendingMachine = new VendingMachine();

        var result = vendingMachine.ReturnMoney();

        Assert.Equal(0, result);
    }
}
