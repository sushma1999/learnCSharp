// See https://aka.ms/new-console-template for more information
// Create a SavingsAccount object
        SavingsAccount account = new SavingsAccount();
        BankAccount bankAccount = new BankAccount();
     

        // Deposit and withdraw money
        account.Deposit(1000);
        account.Withdraw(500);


        // Display the current balance
        account.DisplayBalance(); 
