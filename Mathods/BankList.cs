using Homework14.Interfaces;
using Homework14.Mathods;

public class BankList : IBankList
{
    private List<Bank> banks;

    public BankList()
    {
        banks = new List<Bank>();
    }

    public void CreateBank(Bank newBank)
    {
        banks.Add(newBank);
    }

    public void UpdateBank(Bank bank)
    {
  
        Bank MavjudBank = banks.Find(b => b.Id == bank.Id);
        if (MavjudBank != null)
        {
            MavjudBank.Name = bank.Name;
            MavjudBank.FoundedDate = bank.FoundedDate;
            MavjudBank.Address = bank.Address;
            MavjudBank.PhoneNumber = bank.PhoneNumber;
        }
    }
    public void RemoveBank(Bank bank)
    {
        banks.Remove(bank);
    }

    public List<Bank> GetAllBanks()
    {
        return banks;
    }
}
