// Inheritance: SavingsAccount inherits from Account, adding interest calculation
class SavingsAccount : Account
{
    private decimal interestRate;

    public SavingsAccount(decimal initialBalance, decimal rate) : base(initialBalance)
    {
        interestRate = rate;
    }

    public void CalculateInterest()
    {
        decimal interest = balance * interestRate;
        balance += interest;
        Console.WriteLine($"Interest earned: {interest}. New balance: {balance}");
    }
}