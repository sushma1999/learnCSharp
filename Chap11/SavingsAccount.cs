// Concrete classes implementing specific account types
class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(string accountNumber, string accountHolder, decimal   
 interestRate)
        : base(accountNumber, accountHolder)
    {
        InterestRate = interestRate;
    }

    public override void Withdraw(decimal amount)
    {
        // Savings account specific withdrawal logic (e.g., minimum balance check)
        if (amount > 0 && Balance - amount >= 0)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
        }
    }

    public void CalculateInterest()
    {
        decimal interest = Balance * InterestRate;
        Balance += interest;
        Console.WriteLine($"Interest calculated: {interest:C}. New balance: {Balance:C}");
    }
}
