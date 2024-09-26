// Base class representing a generic bank account
public class BankAccount
{
    public decimal Balance { get;  set; }

    // Virtual method to calculate interest (can be overridden by derived classes)
    public virtual decimal CalculateInterest()
    {
        return Balance * 0.01m; // Default interest rate of 1%
    }
}