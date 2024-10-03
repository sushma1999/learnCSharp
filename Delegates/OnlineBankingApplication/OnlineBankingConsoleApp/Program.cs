// Create a bank account
using System;
namespace OnlineBankingConsoleApp;
internal class Program
{
    private static void Main(string[] args)
    {
        var CorrectPasscode = "1234";
        BankAccount account = new BankAccount("12345", 1000);

        // Create a transaction logger
        CustomTransactionLogger logger = new CustomTransactionLogger();
        Action<string, decimal> warningMessageMethod = (accountNumber, amount) =>
        {
            Console.WriteLine($"Insufficient funds in bnp account {accountNumber} to withdraw {amount:C}");
        };

        Predicate<decimal> HaveBalanceMethod = (balance) => account.Balance > 0 ;
        Func<string, string,bool> EnterPintoWithdrawMethod = (CorrectPasscode, UserPasscode) => CorrectPasscode==UserPasscode;
        
        // bool check = HaveBalanceMethod(account.Balance);
        // Console.WriteLine($"Do you have amount in your account ?",check);

        // Subscribe the logger to the bank account's events
        account.DepositMade += logger.LogDeposit;
        account.WithdrawalMade += logger.LogWithdrawal;
        account.WarningMessage += warningMessageMethod;
        account.HaveBalance += HaveBalanceMethod;
        account.EnterPintoWithdraw +=EnterPintoWithdrawMethod;


        // Perform some transactions
        account.Deposit(500);
        account.Withdraw(1500,CorrectPasscode, "1345");
        account.Withdraw(100,CorrectPasscode, "1234"); // Should trigger insufficient funds message
    }
}