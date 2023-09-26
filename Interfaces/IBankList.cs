using Homework14.Mathods;

public interface IBankList
{
    void CreateBank(Bank newBank);
    void UpdateBank(Bank bank);
    void RemoveBank(Bank bank);
    List<Bank> GetAllBanks();
}