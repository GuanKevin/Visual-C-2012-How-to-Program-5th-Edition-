public class Card
{
    private string face;    // face of card ("Ace", "Deuce")
    private string suit;    // suit of card ("Diamond", "Hearts", "Spades", "Clover")
    private string[] cardFaceandSuit;

    public Card() { }
    public Card(string cardFace, string cardSuit)
    {
        face = cardFace;
        suit = cardSuit;

        cardFaceandSuit = new string[2];
        cardFaceandSuit[0] = cardFace;
        cardFaceandSuit[1] = cardSuit;
    }

    public string[] CardFaceandSuit { get => cardFaceandSuit; set => cardFaceandSuit = value; }

    public override string ToString()
    {
        return face + " of " + suit;
    }
}