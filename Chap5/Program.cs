class Program
{
    // Pass-by-value example: The original account balance remains unchanged
    static void AttemptWithdrawalByValue(BankAccount account, decimal amount)
    {
        if (account.Balance >= amount)
        {
            account.Balance -= amount; // Modifies a copy of the account object
            Console.WriteLine("Withdrawal successful (inside method).");
        }
        else
        {
            Console.WriteLine("Insufficient funds (inside method).");
        }
    }

      static void AttemptDecimalWithdrawalByValue(decimal balance, decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount; // Modifies a copy of the account object
            Console.WriteLine("Withdrawal successful (inside method).");
        }
        else
        {
            Console.WriteLine("Insufficient funds (inside method).");
        }
    }

    // Pass-by-reference example: The original account balance is modified
    static void ProcessWithdrawalByReference(ref BankAccount account, decimal amount)
    {
        if (account.Balance >= amount)
        {
            account.Balance -= amount; // Modifies the original account object
            Console.WriteLine("Withdrawal successful (inside method).");
        }
        else
        {
            Console.WriteLine("Insufficient funds (inside method).");
        }
    }


    // Pass-by-reference example: The original account balance is modified
    static void ProcessDecimalWithdrawalByReference(ref decimal balance, decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount; // Modifies the original account object
            Console.WriteLine("Withdrawal successful (inside method).");
        }
        else
        {
            Console.WriteLine("Insufficient funds (inside method).");
        }
    }
    static void Main()
    {
        BankAccount myAccount = new BankAccount { Balance = 1000 };

        Console.WriteLine($"Original balance: {myAccount.Balance:C}");

        // Pass-by-value attempt
        AttemptWithdrawalByValue(myAccount, 100);
        Console.WriteLine($"Balance after pass-by-value attempt: {myAccount.Balance:C}"); 

        // Pass-by-reference withdrawal
        ProcessWithdrawalByReference(ref myAccount, 100);
        Console.WriteLine($"Balance after pass-by-reference withdrawal: {myAccount.Balance:C}"); 

        
        // Pass-by-value attempt
        AttemptDecimalWithdrawalByValue(myAccount.Balance, 100);
        Console.WriteLine($"Balance after pass-by-value attempt: {myAccount.Balance:C}"); 

        // Pass-by-reference withdrawal
        ProcessDecimalWithdrawalByReference(ref myAccount.Balance, 100);
        Console.WriteLine($"Balance after pass-by-reference withdrawal: {myAccount.Balance:C}"); 
    }
}