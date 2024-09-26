// SavingsAccount class inheriting from BankAccount
public class SavingsAccount : BankAccount
{
    // Public method to display the current balance (utilizes the protected GetBalance method)
    public void DisplayBalance()
    {
        Console.WriteLine($"Current balance in Savings Account: {GetBalance():C}");
    }
}