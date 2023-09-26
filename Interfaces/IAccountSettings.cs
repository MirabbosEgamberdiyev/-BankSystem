
using Homework14.Mathods;

namespace Homework14.Interfaces;

public interface IAccountSettings
{
    void CreateAccount(Account account);
    void UpdateAccount(Account account);
    void RemoveAccount(Account account);
    List<Account> GetAllAccounts();
}