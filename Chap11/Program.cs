// See https://aka.ms/new-console-template for more information

IAccount savingsAccount = new SavingsAccount("123", "Ivan", (decimal)7.5);

savingsAccount.Deposit(1000);
savingsAccount.Withdraw(100);



BankAccount savingsAccount2 = new SavingsAccount("345","III", (decimal)6.5);
savingsAccount2.Deposit(1000);
savingsAccount2.Withdraw(100);

BankAccount currentAccount = new CheckingAccount("111","Ingant",10000);
currentAccount.Deposit(1000);
currentAccount.Withdraw(100);


SavingsAccount savingsAccount3 = new SavingsAccount("123", "Ivan", (decimal)7.5);

savingsAccount3.Deposit(1000);
savingsAccount3.Withdraw(100);
savingsAccount3.CalculateInterest();

