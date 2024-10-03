public class BankAccount
{
    public event Action<string,decimal> WarningMessage;
    public event Predicate<decimal> HaveBalance;
    public event Func<string,string,bool> EnterPintoWithdraw;
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
        //InputPasscode = inputPasscode;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;

        // Raise the DepositMade event (notify subscribers)
        DepositMade?.Invoke(AccountNumber, amount);
        
    }

    public void Withdraw(decimal amount, string originalPasscode, string InputPasscode )
    {
        var IsPinValid =  EnterPintoWithdraw?.Invoke(originalPasscode,InputPasscode)?? false;
        if (IsPinValid)
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