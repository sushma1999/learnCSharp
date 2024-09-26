var externalAccount = new ExternalBankAccount(1000, 0.05m);
externalAccount.Deposit(500);
externalAccount.CalculateInterest();
System.Console.WriteLine($"Account Balance is {externalAccount.balance}");
externalAccount.cautionDeposit = 2000;

