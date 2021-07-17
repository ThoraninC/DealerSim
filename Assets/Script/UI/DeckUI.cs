using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DealerSim.GamblingMedium.Cards;

namespace DealerSim.UI
{
    public class DeckUI : MonoBehaviour
    {
        [SerializeField]
        private int deckNumber = 1;
        [SerializeField]
        private bool hasJoker = default;
        [SerializeField]
        private Deck deck = default;

        // Start is called before the first frame update
        void Start()
        {
            deck = new Deck(deckNumber,hasJoker);
            deck = Deck.InsertShuffle(deck);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Shuffle()
        {
            deck = Deck.InsertShuffle(deck);
        }
    }
}