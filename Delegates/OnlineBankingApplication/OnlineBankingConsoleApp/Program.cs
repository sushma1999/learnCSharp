// Create a bank account
using System;
namespace OnlineBankingConsoleApp;
internal class Program
{
    private static void Main(string[] args)
    {
        BankAccount account = new BankAccount("12345", 1000);

        // Create a transaction logger
        CustomTransactionLogger logger = new CustomTransactionLogger();
        Action<string, decimal> warningMessageMethod = (accountNumber, amount) =>
        {
            Console.WriteLine($"Insufficient funds in account {accountNumber} to withdraw {amount:C}");
        };

        // Subscribe the logger to the bank account's events
        account.DepositMade += logger.LogDeposit;
        account.WithdrawalMade += logger.LogWithdrawal;
        account.WarningMessage += warningMessageMethod;

//create a action delegate to print warning message when account has insufficient funds and subscribe it to the event withdrawalMade
       

        // Perform some transactions
        account.Deposit(500);
        account.Withdraw(200);
        account.Withdraw(700); // Should trigger insufficient funds message
    }
}