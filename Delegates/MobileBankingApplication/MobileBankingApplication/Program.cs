// See https://aka.ms/new-console-template for more information
BankAccount account = new BankAccount("12345", 1000);

// Create a transaction logger

// Subscribe the logger to the bank account's events
account.DepositMade += delegate (string accountNumber, decimal amount) {
    Console.WriteLine($"Deposit of {amount:C} made to account {accountNumber}");
};

account.WithdrawalMade += delegate (string accountNumber, decimal amount) {
Console.WriteLine($"Withdrawal of {amount:C} made to account {accountNumber}");
};

account.MinimumBalanceExhausted += (accountNumber,Balance) => Console.WriteLine($"Account {accountNumber} exceeded the minimum balance, current Balance {Balance}");

// Perform some transactions
account.Deposit(500);
account.Withdraw(200);
account.Withdraw(700); // Should trigger insufficient funds message
