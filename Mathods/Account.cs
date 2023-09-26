namespace Homework14.Mathods;


public class Account : User
{
    public int AccountNumber { get; set; }
    public DateTime CreatedDate { get; set; }
    public List<Card> Cards { get; set; }
    public double TotalBalance { get; set; }
}
