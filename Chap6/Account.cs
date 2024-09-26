// Encapsulation: Bundling data (balance) and methods (Deposit, Withdraw) within a single unit (Account)
public class Account
{
    protected decimal balance;
    protected internal decimal cautionDeposit;

    public Account(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}