namespace CoreBankingLogic;

using System;
using System.Collections.Generic;

// Subject (Bank Account)
public class BankAccount
{
    public delegate void AccountBalanceChangedEventHandler(object sender, AccountBalanceChangedEventArgs e);
    public event AccountBalanceChangedEventHandler AccountRiskChanged;

    public decimal Balance { get; set; }

    protected virtual void OnAccountBalanceChanged(AccountBalanceChangedEventArgs e)
    {
        AccountRiskChanged?.Invoke(this, e);
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
        OnAccountBalanceChanged(new AccountBalanceChangedEventArgs(Balance));
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
            OnAccountBalanceChanged(new AccountBalanceChangedEventArgs(Balance));
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }
}
