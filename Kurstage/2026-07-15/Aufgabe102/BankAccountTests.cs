namespace Aufgabe102;

public class BankAccountTests
{
    [Fact]
    public void Constructor_SetsInitialBalance()
    {
        var account = new BankAccount(100);

        Assert.Equal(100, account.Balance);
    }

    [Fact]
    public void Deposit_IncreasesBalance()
    {
        var account = new BankAccount(100);

        account.Deposit(50);

        Assert.Equal(150, account.Balance);
    }

    [Fact]
    public void Deposit_ThrowsArgumentException_WhenAmountIsZero()
    {
        var account = new BankAccount(100);

        Assert.Throws<ArgumentException>(() => account.Deposit(0));
    }

    [Fact]
    public void Deposit_ThrowsArgumentException_WhenAmountIsNegative()
    {
        var account = new BankAccount(100);

        Assert.Throws<ArgumentException>(() => account.Deposit(-50));
    }

    [Fact]
    public void Withdraw_DecreasesBalance()
    {
        var account = new BankAccount(100);

        account.Withdraw(50);

        Assert.Equal(50, account.Balance);
    }

    [Fact]
    public void Withdraw_DecreasesBalanceToZeroWhenWithdrawingEverything()
    {
        var account = new BankAccount(100);

        account.Withdraw(100);

        Assert.Equal(0, account.Balance);
    }

    [Fact]
    public void Withdraw_ThrowsInvalidOperationException_WhenBalanceIsTooLow()
    {
        var account = new BankAccount(100);

        Assert.Throws<InvalidOperationException>(() => account.Withdraw(150));
    }

    [Fact]
    public void Withdraw_ThrowsArgumentException_WhenAmountIsZero()
    {
        var account = new BankAccount(100);

        Assert.Throws<ArgumentException>(() => account.Withdraw(0));
    }

    [Fact]
    public void Withdraw_ThrowsArgumentException_WhenAmountIsNegative()
    {
        var account = new BankAccount(100);

        Assert.Throws<ArgumentException>(() => account.Withdraw(-50));
    }

    [Fact]
    public void HasEnoughFunds_ReturnsTrue_WhenBalanceIsEqualToAmount()
    {
        var account = new BankAccount(100);

        var result = account.HasEnoughFunds(100);

        Assert.True(result);
    }

    [Fact]
    public void HasEnoughFunds_ReturnsTrue_WhenBalanceIsBiggerThanAmount()
    {
        var account = new BankAccount(150);

        var result = account.HasEnoughFunds(100);

        Assert.True(result);
    }

    [Fact]
    public void HasEnoughFunds_ReturnsFalse_WhenBalanceIsLowerThanAmount()
    {
        var account = new BankAccount(50);

        var result = account.HasEnoughFunds(100);

        Assert.False(result);
    }
}
