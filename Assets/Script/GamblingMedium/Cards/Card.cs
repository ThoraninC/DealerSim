using System;
using UnityEngine;
using DealerSim.Enumuration;

namespace DealerSim.GamblingMedium.Cards
{
    [Serializable]
    public class Card
    {
        [SerializeField]
        private CardSuit suit = CardSuit.joker;
        [SerializeField]
        private CardRank rank = CardRank.ace;

        public CardSuit Suit => suit;
        public CardRank Rank => rank;

        public Card(CardSuit suit = CardSuit.joker, CardRank rank = CardRank.ace)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public void innerSetCard()
        {
            setCard(suit, rank);
        }

        public void setCard(Card card)
        {
            setCard(card.Suit, card.Rank);
        }

        public void setCard(CardSuit suit = CardSuit.joker, CardRank rank = CardRank.ace)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public void getCardProperties(out CardSuit suit, out CardRank rank)
        {
            suit = Suit;
            rank = Rank;
        }
    }
}
