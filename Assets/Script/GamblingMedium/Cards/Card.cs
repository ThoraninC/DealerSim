using DealerSim.Enumuration;

namespace DealerSim.GamblingMedium.Cards
{
    public class Card
    {
        public CardSuit Suit { get; private set; }
        public CardRank Rank { get; private set; }

        public Card(CardSuit suit = CardSuit.Jokers, CardRank rank = CardRank.Ace)
        {
            Suit = suit;
            Rank = rank;
        }

        public void getCardProperties(out CardSuit suit, out CardRank rank)
        {
            suit = Suit;
            rank = Rank;
        }
    }
}
