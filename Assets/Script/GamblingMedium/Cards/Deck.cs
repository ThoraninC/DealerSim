using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DealerSim.Enumuration;

namespace DealerSim.GamblingMedium.Cards
{
    [Serializable]
    public class Deck
    {
        [SerializeField]
        private List<Card> cards = default;

        public Deck(int deckSet = 1,bool joker = false)
        {
            cards = new List<Card>();
            for (int n=0;n<deckSet;n++)
            {
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 13; j++)
                    {
                        cards.Add(new Card((CardSuit)i, (CardRank)j));
                    }
                }

                if (joker)
                {
                    cards.Add(new Card(CardSuit.joker, CardRank.ace));
                    cards.Add(new Card(CardSuit.joker, CardRank.two));
                }
            }
        }

        public static Deck InsertShuffle(Deck deck)
        {
            System.Random rnd = new System.Random();

            var values = deck.cards.ToArray();
            deck.cards.Clear();
            foreach (var value in values.OrderBy(x => rnd.Next()))
                deck.cards.Add(value);

            return deck;
        }
    }
}

