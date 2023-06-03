/* Objectives:
•  Define enumerations for card colors and card ranks.
• Define a Card class to represent a card with a color and a rank, as described above.
• Add properties or methods that tell you if a card is a number or symbol card (the equivalent of a 
face card).
• Create a main method that will create a card instance for the whole deck (every color with every 
rank) and display each (for example, “The Red Ampersand” and “The Blue Seven”).
 */

Color[] colors = new Color[] { Color.red, Color.green, Color.blue, Color.yellow };
Rank[] ranks = new Rank[] { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.DollarSign, Rank.Percent, Rank.Caret, Rank.Ampersand };


foreach (Color color in colors)
{
    foreach (Rank rank in ranks)
    {
        Card card = new Card(rank, color);
        Console.WriteLine($"The {card.Rank} of {card.Color}");
    }
}

public class Card
{
    public Rank Rank { get; }
    public Color Color { get; }
    
    public Card(Rank rank, Color color)
    {
        Rank = rank;
        Color = color;
    }
    
    public bool IsSymbolCard => Rank is Rank.Ampersand or Rank.Caret or Rank.DollarSign or Rank.Percent;
    public bool IsNumberCard => !IsSymbolCard;
    
    
}



public enum Color
{
    red, green, blue, yellow
}

public enum Rank
{
    One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand
}