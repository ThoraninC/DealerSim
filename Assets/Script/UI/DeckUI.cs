using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DealerSim.GamblingMedium.Cards;

namespace DealerSim.UI
{
    public class DeckUI : MonoBehaviour
    {
        [SerializeField]
        Deck deck = default;

        // Start is called before the first frame update
        void Start()
        {
            deck = new Deck(1);
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