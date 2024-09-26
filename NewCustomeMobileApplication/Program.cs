// See https://aka.ms/new-console-template for more information
using CoreBankingLogic;
using NewCustomeMobileApplication;

var bankAccount = new BankAccount();
var savingsBankAccount = new SavingsBankAccount();
//var whatsappNotificationService = new WhatsappNotificationService();
//var emailNotificationService = new EmailNotificationService();

//bankAccount.AccountBalanceChanged += whatsappNotificationService.OnAccountBalanceChanged;
//bankAccount.AccountBalanceChanged += emailNotificationService.OnAccountBalanceChanged;

bankAccount.AccountRiskChanged += savingsBankAccount.CallManager;
bankAccount.AccountRiskChanged += savingsBankAccount.SendMailToManager;
bankAccount.AccountRiskChanged += savingsBankAccount.SendMailToCashier;


bankAccount.Deposit(1000);
bankAccount.AccountRiskChanged -= savingsBankAccount.CallManager;
bankAccount.Withdraw(200);
// bankAccount.Deposit(2000);
// bankAccount.Withdraw(300);



