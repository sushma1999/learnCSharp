public class BankAccount
{
    public string AccountNumber { get; }
    public decimal Balance { get; private set; }

    // An event for handling deposits
    public event TransactionHandler DepositMade;

    // An event for handling withdrawals
    public event TransactionHandler WithdrawalMade;

    public event BalanceAlertHandler MinimumBalanceExhausted;

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;

        // Raise the DepositMade event (notify subscribers)
        DepositMade?.Invoke(AccountNumber, amount);
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            // Raise the WithdrawalMade event
            WithdrawalMade?.Invoke(AccountNumber, amount);
            if (Balance < 1000)
            {
                MinimumBalanceExhausted?.Invoke(AccountNumber, Balance);
            }

        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }
}