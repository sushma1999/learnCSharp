// Polymorphism: Different account types can have their own 'Withdraw' behavior
class CheckingAccount : Account
{
    private decimal overdraftLimit;

    public CheckingAccount(decimal initialBalance, decimal limit) : base(initialBalance)
    {
        overdraftLimit = limit;
    }

    public new void Withdraw(decimal amount) // 'new' keyword hides base class method
    {
        if (balance - amount >= -overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded.");
        }
    }
}
