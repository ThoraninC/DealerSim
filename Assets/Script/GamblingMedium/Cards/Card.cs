using System;
using UnityEngine;
using DealerSim.Enumuration;

namespace DealerSim.GamblingMedium.Cards
{
    [Serializable]
    public class Card
    {
        [SerializeField]
        private CardSuit innerSuit = CardSuit.joker;
        [SerializeField]
        private CardRank innerRank = CardRank.ace;

        public CardSuit Suit => innerSuit;
        public CardRank Rank => innerRank;

        public Card(CardSuit suit = CardSuit.joker, CardRank rank = CardRank.ace)
        {
            innerSuit = suit;
            innerRank = rank;
        }

        public void innerSetCard()
        {
            setCard(innerSuit, innerRank);
        }

        public void setCard(Card card)
        {
            setCard(card.Suit, card.Rank);
        }

        public void setCard(CardSuit suit = CardSuit.joker, CardRank rank = CardRank.ace)
        {
            innerSuit = suit;
            innerRank = rank;
        }

        public void getCardProperties(out CardSuit suit, out CardRank rank)
        {
            suit = Suit;
            rank = Rank;
        }
    }
}
