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

        // Subscribe the logger to the bank account's events
        account.DepositMade += logger.LogDeposit;
        account.WithdrawalMade += logger.LogWithdrawal;

        // Perform some transactions
        account.Deposit(500);
        account.Withdraw(200);
        account.Withdraw(700); // Should trigger insufficient funds message
    }
}