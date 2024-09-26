// Abstract class providing a base implementation and shared properties
abstract class BankAccount : IAccount
{
    public string AccountNumber { get; set; }
    public string AccountHolder { get; set; }
    public decimal Balance { get; protected set; } // Protected for controlled access

    public BankAccount(string accountNumber, string accountHolder)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");   

        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");   

        }
    }

    public abstract void Withdraw(decimal amount); // Abstract method for specific withdrawal logic
}