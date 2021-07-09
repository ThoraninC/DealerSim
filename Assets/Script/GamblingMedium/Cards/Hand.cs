using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DealerSim;

namespace DealerSim.GamblingMedium.Cards
{
    public class Hand
    {
        [SerializeField]
        private List<Card> cards = default;
        [SerializeField]

        public Hand()
        {
            cards = new List<Card>();
        }

        public static int LastDigitScore(Hand hand)
        {
            int score = 0;

            foreach (Card card in hand.cards)
            {
                if ((int)card.Rank <=10)
                {
                    score += (int)card.Rank;
                }
                else
                {
                    score += 10;
                }
            }

            return score % 10;
        }

        public static int TotalScore(Hand hand)
        {
            int score = 0;

            foreach (Card card in hand.cards)
            {
                if ((int)card.Rank <= 10)
                {
                    score += (int)card.Rank;
                }
                else
                {
                    score += 10;
                }
            }

            return score % 10;
        }

        public static Hand operator +(Hand a, Hand b)
        {
            a.cards.AddRange(b.cards);

            return a;
        }
    }
}

