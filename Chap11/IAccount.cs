// Interface defining common account behaviors
interface IAccount
{
    decimal Balance { get; }
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
}