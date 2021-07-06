using System;
using UnityEngine;
using DealerSim.Enumuration;

namespace DealerSim.GamblingMedium.Cards
{
    [Serializable]
    public class Card
    {
        [SerializeField]
        private CardSuit innerSuit = default;
        [SerializeField]
        private CardRank innerRank = default;

        public CardSuit Suit { get; private set; }
        public CardRank Rank { get; private set; }

        public Card(CardSuit suit = CardSuit.Jokers, CardRank rank = CardRank.Ace)
        {
            Suit = suit;
            Rank = rank;
            innerSuit = Suit;
            innerRank = Rank;
        }

        public void getCardProperties(out CardSuit suit, out CardRank rank)
        {
            suit = Suit;
            rank = Rank;
        }
    }
}
