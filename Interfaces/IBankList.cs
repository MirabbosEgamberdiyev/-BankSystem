using Homework14;

public interface IBankList
{
    void CreateBank(Bank newBank);
    void UpdateBank(Bank bank);
    void RemoveBank(Bank bank);
    List<Bank> GetAllBanks();
}