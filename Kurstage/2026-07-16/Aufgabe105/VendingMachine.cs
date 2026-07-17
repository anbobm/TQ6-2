namespace Aufgabe105;

public class VendingMachine
{
    public decimal CurrentBalance { get; private set; }

    public decimal InsertMoney(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be positive.");
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
    decimal moneyToReturn = CurrentBalance;
    CurrentBalance = 0.00m;
    return moneyToReturn;
}
}