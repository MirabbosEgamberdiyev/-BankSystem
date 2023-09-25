using Homework14;
using System.Net;

Bank bank1 = new Bank
{
    Id = 1,
    Name = "Uzum Bank",
    FoundedDate = 2023,
    Address = "Toshkent , Uzbekiston",
    PhoneNumber = 88999499
};
Bank bank2 = new Bank
{
    Id = 2,
    Name = "Anor Bank",
    FoundedDate = 2021,
    Address = "Namangan , Uzbekiston",
    PhoneNumber = 889996399

};
BankList bankList = new BankList();
bankList.CreateBank(bank1);
bankList.CreateBank(bank2); 
var allBanks = bankList.GetAllBanks();

foreach (var bank in allBanks)
{
    Console.WriteLine("Bank ID : {0}, Bank Name : {1}, FoundedDate : {2}, Address {3}, PhoneNumber :{4}",bank.Id, bank.Name, bank.FoundedDate, bank.Address, bank.PhoneNumber);
}
Console.WriteLine();
Console.WriteLine();
Bank updatedBank = new Bank
{
    Id = 1,
    Name = "TBC Bank",
    FoundedDate = 2023,
    Address = "Farg'ona",
    PhoneNumber = 789997788
};
bankList.UpdateBank(updatedBank);
allBanks = bankList.GetAllBanks();
foreach (var bank in allBanks)
{
    Console.WriteLine("Bank ID : {0} , Bank Name : {1}, FoundedDate : {2}, Address {3}, PhoneNumber :{4}",bank.Id, bank.Name, bank.FoundedDate, bank.Address, bank.PhoneNumber);
}
Console.WriteLine();
Console.WriteLine();
bankList.RemoveBank(bank2);
allBanks = bankList.GetAllBanks();
foreach (var bank in allBanks)
{
    Console.WriteLine("Bank ID : {0} , Bank Name : {1}, FoundedDate : {2}, Address {3}, PhoneNumber :{4}", bank.Id, bank.Name, bank.FoundedDate, bank.Address, bank.PhoneNumber);
}
