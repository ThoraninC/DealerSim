using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;
using DealerSim.GamblingMedium.Cards;
using DealerSim.Enumuration;

namespace DealerSim.UI
{
    public class CardElementUI : MonoBehaviour
    {
        [SerializeField]
        private Image cardImage = default;
        [SerializeField]
        private Card card = default;

        private AssetReferenceSprite cardReference;

        // Start is called before the first frame update
        void Start()
        {
            SetCardSprite(new Card(CardSuit.spades, CardRank.king));
            SetCardSprite(new Card(CardSuit.spades, CardRank.four));
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void SetCardSprite(Card cardface)
        {
            string playingstring = Constant.CardConstants.cardFolder;
            if ((int)cardface.Rank > 1 && (int)cardface.Rank < 11)
            {
                playingstring += (int)cardface.Rank;
            }
            else
            {
                playingstring += cardface.Rank;
            }

            playingstring += Constant.CardConstants.cardInfix + cardface.Suit + Constant.CardConstants.spriteExtention;
            cardReference = new AssetReferenceSprite(playingstring);
            cardReference.LoadAssetAsync().Completed += (result) => 
            {
                cardImage.sprite = result.Result; 
            };
        }
    }
}

