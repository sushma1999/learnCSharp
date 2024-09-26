using CoreBankingLogic;

namespace MobileBankingTeam;


public class WhatsappNotificationService
{
    public void OnAccountBalanceChanged(object sender, AccountBalanceChangedEventArgs e)
    {
        Console.WriteLine($"Whatsapp Mesage sent: Account balance updated to {e.NewBalance:C}");
    }
}
