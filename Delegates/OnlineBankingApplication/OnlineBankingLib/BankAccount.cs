public class BankAccount
{
    public event Action<string,decimal> WarningMessage;
    public event Predicate<decimal> HaveBalance;
    public event Func<string,string> EnterPintoWithdraw;
    public string AccountNumber { get; }
    public decimal Balance { get; private set; }
    public string originalPasscode ="2024";


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

    public void Withdraw(decimal amount,string pin)
    {
        var pinNo = EnterPintoWithdraw.Invoke(pin); // didnt make it nullable
        if (pinNo.Equals(originalPasscode))
        {       
            Console.WriteLine($"Pin is verified");
            var haveBalance = HaveBalance?.Invoke(amount);
            if (haveBalance.HasValue && haveBalance.Value)
            {
                Balance -= amount;
                // Raise the WithdrawalMade event
                WithdrawalMade?.Invoke(AccountNumber, amount);
                WarningMessage?.Invoke(AccountNumber,amount);
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
}