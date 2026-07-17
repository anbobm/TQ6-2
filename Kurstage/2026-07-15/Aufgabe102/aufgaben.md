## Aufgabe 102
Folgende Klasse BankAccount sei gegeben:
public class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");

        Balance -= amount;
    }

    public bool HasEnoughFunds(decimal amount)
    {
        return Balance >= amount;
    }
}


Schreibe Unit-Tests für die folgenden Fälle:

## Konstruktor
Prüfe, ob der Anfangskontostand korrekt gesetzt wird.
Deposit (Einzahlen)
Prüfe, ob sich der Kontostand nach einer gültigen Einzahlung erhöht.
Prüfe, ob bei einer Einzahlung von 0 eine ArgumentException ausgelöst wird.
Prüfe, ob bei einer negativen Einzahlung eine ArgumentException ausgelöst wird.
Withdraw (Abheben)
Prüfe, ob sich der Kontostand nach einer gültigen Auszahlung verringert.
Prüfe, ob das Abheben des gesamten Guthabens den Kontostand auf 0 setzt.
Prüfe, ob beim Abheben eines zu hohen Betrags eine InvalidOperationException ausgelöst wird.
Prüfe, ob beim Abheben von 0 eine ArgumentException ausgelöst wird.
Prüfe, ob beim Abheben eines negativen Betrags eine ArgumentException ausgelöst wird.
HasEnoughFunds
Prüfe, ob die Methode true zurückgibt, wenn genügend Guthaben vorhanden ist.
Prüfe, ob die Methode true zurückgibt, wenn Guthaben und Betrag genau gleich sind.
Prüfe, ob die Methode false zurückgibt, wenn nicht genügend Guthaben vorhanden ist.
Benennung der Tests
Versuche, aussagekräftige Testnamen zu verwenden, zum Beispiel:

## Constructor_SetsInitialBalance
Deposit_IncreasesBalance
Deposit_ThrowsArgumentException_WhenAmountIsZero
Withdraw_DecreasesBalance
Withdraw_ThrowsInvalidOperationException_WhenBalanceIsTooLow
HasEnoughFunds_ReturnsTrue_WhenBalanceIsEqualToAmount