
using CoreBankingLogic;

namespace OnlineBankingTeam;

// Observers (Notification Services)
public class EmailNotificationService
{
    public void OnAccountBalanceChanged(object sender, AccountBalanceChangedEventArgs e)
    {
        Console.WriteLine($"Email sent: Account balance updated to {e.NewBalance:C}");
    }
}
