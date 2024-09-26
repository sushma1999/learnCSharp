using System;
using CoreBankingLogic;

namespace NewCustomeMobileApplication;

public class SavingsBankAccount
{

 public void SendMailToManager(object sender,AccountBalanceChangedEventArgs e)
    {
        System.Console.WriteLine("SEND Mail to managers");

    }

    public void CallManager(object sender,AccountBalanceChangedEventArgs e)
    {
        System.Console.WriteLine("Initiate Call to Manager");

    }

    public void SendMailToCashier(object sender,AccountBalanceChangedEventArgs e)
    {

        System.Console.WriteLine("Alert bank cashier");

    }

}
