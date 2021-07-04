using DealerSim.Enumuration;

namespace DealerSim.GamblingMedium
{
    public class Card
    {
        public CardSuit Suit { get; private set; }
        public CardRank Rank { get; private set; }

        public void getCardProperties(out CardSuit suit, out CardRank rank)
        {
            suit = Suit;
            rank = Rank;
        }
    }
}
