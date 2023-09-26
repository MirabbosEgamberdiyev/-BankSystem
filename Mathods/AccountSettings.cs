using Homework14.Interfaces;

namespace Homework14.Mathods;
public class AccountSettings : IAccountSettings, IAccountPayments
{
    private List<Account> accounts;

    public AccountSettings()
    {
        accounts = new List<Account>();
    }

    public void CreateAccount(Account account)
    {
        accounts.Add(account);
    }

    public void UpdateAccount(Account account)
    {

        Account MavjudHisob = accounts.Find(a => a.Id == account.Id);
        if (MavjudHisob != null)
        {
            MavjudHisob.FirstName = account.FirstName;
            MavjudHisob.LastName = account.LastName;
            MavjudHisob.BirthDate = account.BirthDate;
            MavjudHisob.PhoneNumber = account.PhoneNumber;
        }
    }

    public void RemoveAccount(Account account)
    {
        accounts.Remove(account);
    }

    public List<Account> GetAllAccounts()
    {
        return accounts;
    }

    public void Withdraw(Account account, Card card, double amount)
    {

        if (account.Cards.Contains(card))
        {
            if (account.TotalBalance >= amount)
            {
                account.TotalBalance -= amount;
                Console.WriteLine($"Withdrawal of {amount} successful from Account Number: {account.AccountNumber}.");
            }
            else
            {
                Console.WriteLine($"Insufficient balance in Account Number: {account.AccountNumber}.");
            }
        }
        else
        {
            Console.WriteLine($"Card not linked to Account Number: {account.AccountNumber}.");
        }
    }

    public void Deposit(Account account, Card card, double amount)
    {

        if (account.Cards.Contains(card))
        {
            account.TotalBalance += amount;
            Console.WriteLine($"Deposit of {amount} successful to Account Number: {account.AccountNumber}.");
        }
        else
        {
            Console.WriteLine($"Card not linked to Account Number: {account.AccountNumber}.");
        }
    }

    public void CreateCard(Account account, Card card)
    {

        account.Cards.Add(card);
        Console.WriteLine($"Card created and linked to Account Number: {account.AccountNumber}.");
    }

    public void RemoveCard(Account account, Card card)
    {
        account.Cards.Remove(card);
        Console.WriteLine($"Card removed from Account Number: {account.AccountNumber}.");
    }
}