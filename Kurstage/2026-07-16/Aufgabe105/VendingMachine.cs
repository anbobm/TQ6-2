public class VendingMachine
{
    public decimal InsertMoney(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Only positive amounts allowed");
        }

        CurrentBalance += amount;

        return CurrentBalance;
    }

    public bool BuyDrink()
    {
        if (CurrentBalance < 2.50m)
        {
            return false;
        }

        CurrentBalance -= 2.50m;
        return true;
    }

    public decimal ReturnMoney()
    {
        var balance = CurrentBalance;
        CurrentBalance = 0;

        return balance;
    }

    public decimal CurrentBalance { get; private set; }
}