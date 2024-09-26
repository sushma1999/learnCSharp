
SavingsAccount savings = new SavingsAccount(1000, 0.05m);
CheckingAccount checking = new CheckingAccount(2000, 500);

savings.Deposit(500);
savings.CalculateInterest();
savings.cautionDeposit = 1000;

checking.Withdraw(2500); // Utilizes overdraft
checking.Withdraw(100);
checking.cautionDeposit = 2000;