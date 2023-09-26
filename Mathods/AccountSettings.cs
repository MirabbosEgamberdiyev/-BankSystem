
using Homework14.Interfaces;
using Homework14.Mathods;

namespace Homework14;
public class AccountSettings : IAccountSettings, IAccountPayments
{

    private List<Account> Accounts = new List<Account>();
    public int TotalCount { get; set; }


    public void CreateAccount(Account account)
    {
        Accounts.Add(account);
    }

    public void CreateCard(Account account, Card card)
    {
        throw new NotImplementedException();
    }

    public void Deposit(Account account, Card card, double amount)
    {
        throw new NotImplementedException();
    }

    public List<Account> GetAllAccounts()
    {
        throw new NotImplementedException();
    }

    public void RemoveAccount(Account account)
    {
        Accounts.Remove(account);
    }

    public void RemoveCard(Account account, Card card)
    {
        throw new NotImplementedException();
    }

    public void UpdateAccount(Account account)
    {
        Account MavjudAccount = account;
        if (Accounts.Contains(account))
        {
            Console.WriteLine("Bu account alla qachon mavjud!");
        }
        else
        {
            MavjudAccount.AccountNumber = account.AccountNumber;
            MavjudAccount.CreatedDate = account.CreatedDate;
            MavjudAccount.Cards = account.Cards;
            MavjudAccount.TotalBalance = account.TotalBalance;
        }
    }

    public void Withdraw(Account account, Card card, double amount)
    {
        throw new NotImplementedException();
    }
}