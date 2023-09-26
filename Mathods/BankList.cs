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

    public List<Bank> GetAllBanks()
    {
        return banks;
    }

    public void RemoveBank(Bank bank)
    {
        banks.Remove(bank);
    }

    public void UpdateBank(Bank bank)
    {
        
       Bank MavjudBank = bank;
        if (banks.Contains(bank))
        {
            Console.WriteLine("Iltimos boshqa bank nomini kiriting bu nom band");
        }
        else
        {
            MavjudBank.Name = bank.Name;
            MavjudBank.FoundedDate = bank.FoundedDate;
            MavjudBank.Address = bank.Address;
            MavjudBank.PhoneNumber = bank.PhoneNumber;
        }

    }
}



