namespace Homework14.Mathods;

public class Card
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public DateTime ValidDate { get; set; }
    public CardType Type { get; set; }
    public double Balance { get; set; }
}
public enum CardType
{
    Uzcard,
    Humo,
    Visa,
    Master,
    Union
}
