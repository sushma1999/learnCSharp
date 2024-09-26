public class ExternalBankAccount:Account
{
    
    private decimal interestRate;

    public ExternalBankAccount(decimal initialBalance, decimal rate) : base(initialBalance)
    {
        interestRate = rate;
    }

    public void CalculateInterest()
    {
        decimal interest = balance * interestRate;
        balance += interest;
        Console.WriteLine($"Interest earned: {interest}. New balance: {balance}");
        var test =cautionDeposit;
    }

}