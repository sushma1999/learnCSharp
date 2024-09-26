// BankAccount class representing a user's bank account
public class BankAccount
{
    // Private field to store the account balance
    private decimal balance;

    // Public method to deposit money into the account
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Public method to withdraw money from the account
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
        }
    }

    // Protected method to get the current balance (accessible within this class and derived classes)
    protected decimal GetBalance()
    {
        return balance;
    }

    
}
