// Derived class representing a savings account with a higher interest rate
public class SavingsAccount : BankAccount
{
    // Override the CalculateInterest method to provide a different implementation
    public override decimal CalculateInterest()
    {
        return Balance * 0.03m; // Savings account interest rate of 3%
    }
}
