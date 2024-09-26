namespace CoreBankingLogic;
// EventArgs for the event
public class AccountBalanceChangedEventArgs : EventArgs
{
    public decimal NewBalance { get; }

    public AccountBalanceChangedEventArgs(decimal newBalance)
    {
        NewBalance = newBalance;
    }
}