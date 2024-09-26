// See https://aka.ms/new-console-template for more information
BankAccount regularAccount = new BankAccount { Balance = 1000 };
SavingsAccount savingsAccount = new SavingsAccount { Balance = 1000 };

Console.WriteLine($"Regular Account Interest: {regularAccount.CalculateInterest():C}");
Console.WriteLine($"Savings Account Interest: {savingsAccount.CalculateInterest():C}");
