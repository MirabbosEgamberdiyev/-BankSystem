

using Homework14.Mathods;

namespace Homework14.Interfaces;

public interface IAccountPayments
{
    void Withdraw(Account account, Card card, double amount);
    void Deposit(Account account, Card card, double amount);
    void CreateCard(Account account, Card card);
    void RemoveCard(Account account, Card card);
}