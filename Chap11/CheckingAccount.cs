class CheckingAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; }

    public CheckingAccount(string accountNumber, string accountHolder, decimal overdraftLimit)
        : base(accountNumber, accountHolder)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override void Withdraw(decimal amount)
    {
        // Checking account specific withdrawal logic (e.g., overdraft handling)
        if (amount > 0 && Balance - amount >= -OverdraftLimit)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or exceeded overdraft limit.");
        }
    }
}