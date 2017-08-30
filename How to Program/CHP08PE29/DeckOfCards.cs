using System;

public class DeckOfCards
{
    private Card[] deck;
    private int currentCard;
    private const int NUMBER_OF_CARDS = 52;
    private Random randomNumbers;

    public DeckOfCards()
    {
        string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        deck = new Card[NUMBER_OF_CARDS];
        currentCard = 0;
        randomNumbers = new Random();

        for (int count = 0; count < deck.Length; ++count)
            deck[count] = new Card(faces[count % 13], suits[count / 13]);
    }

    public void Deal5Cards()
    {
       
        Card[] handOf5 = new Card[5];

        for (int i = 0; i < handOf5.Length; i++)
        {
            handOf5[i] = DealCard();
            Console.WriteLine(handOf5[i]);
        }

        PokerHand(handOf5);
    }

    private void PokerHand(Card[] handOf5)
    {
        Console.WriteLine();

        if (Pair(handOf5))
        {
            if (FourOfAKind(handOf5))
                Console.WriteLine("You've got four of a kind!");
            else if (ThreeOfAKind(handOf5))
                Console.WriteLine("You've got three of a kind!");
            else if (TwoPair(handOf5))
                Console.WriteLine("You've got two pair!");
            else
                Console.WriteLine("You've got a pair!");
        }
    }

    public bool FourOfAKind(Card[] handOf5)
    {
        for (int i = 0; i < handOf5.Length - 3; i++)
        {
            int counter = 1;
            for (int j = i + 1; j < handOf5.Length; j++)
            {
                if (handOf5[i].CardFaceandSuit[0] == handOf5[j].CardFaceandSuit[0])
                    counter++;

                if (counter == 4)
                    return true;
            }
        }

        return false;
    }

    public bool ThreeOfAKind(Card[] handOf5)
    {
        for (int i = 0; i < handOf5.Length - 2; i++)
        {
            int counter = 1;
            for (int j = i + 1; j < handOf5.Length; j++)
            {
                if (handOf5[i].CardFaceandSuit[0] == handOf5[j].CardFaceandSuit[0])
                    counter++;

                if (counter == 3)
                    return true;
            }
        }

        return false;
    }

    public bool TwoPair(Card[] handOf5)
    {
        bool onePair = false;
        string cardFace = "";

        for (int i = 0; i < handOf5.Length - 1; i++)
        {
            for (int j = i + 1; j < handOf5.Length; j++)
            {
                if (!onePair)
                {
                    if (handOf5[i].CardFaceandSuit[0] == handOf5[j].CardFaceandSuit[0])
                    {
                        cardFace = handOf5[i].CardFaceandSuit[0];
                        onePair = true;
                    }
                }
                else if (handOf5[i].CardFaceandSuit[0] == handOf5[j].CardFaceandSuit[0] 
                    && handOf5[i].CardFaceandSuit[0] != cardFace)
                {
                    return true;
                }
            }
        }

        return false;

    }

    public bool Pair(Card[] handOf5)
    {      
        for (int i = 0; i < handOf5.Length -1; i++)
        {
            for (int j = i + 1; j < handOf5.Length; j++)
            {
                if (handOf5[i].CardFaceandSuit[0] == handOf5[j].CardFaceandSuit[0])
                    return true;
            }
        }

        return false;
    }

    public void Shuffle()
    {
        currentCard = 0;

        for (int first = 0; first < deck.Length; ++first)
        {
            int second = randomNumbers.Next(NUMBER_OF_CARDS);

            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;
        }
    }

    public Card DealCard()
    {
        if (currentCard < deck.Length)
            return deck[currentCard++];
        else
            return null;
    }
}