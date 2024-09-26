using System;

namespace OnlineBankingConsoleApp;

public class CustomTransactionLogger
{
      public void LogDeposit(string accountNumber, decimal amount)
    {
        Console.WriteLine($"Deposit of {amount:C} made to account {accountNumber}");
    }

    public void LogWithdrawal(string accountNumber, decimal amount)
    {
        Console.WriteLine($"Withdrawal of {amount:C} made from account {accountNumber}");
    }

}
