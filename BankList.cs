using Homework14.Interfaces;
using Homework14;

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
  
        Bank MavkudBank = banks.Find(b => b.Id == bank.Id);
        if (MavkudBank != null)
        {
            MavkudBank.Name = bank.Name;
            MavkudBank.FoundedDate = bank.FoundedDate;
            MavkudBank.Address = bank.Address;
            MavkudBank.PhoneNumber = bank.PhoneNumber;
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
