using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using DealerSim.GamblingMedium.Cards;

namespace DealerSim.UI
{
    public class CardElementUI : MonoBehaviour
    {

        [SerializeField]
        private Image cardImage = default;
        [SerializeField]
        private Card card = default;
        [SerializeField]
        private bool isFaceUp = default;

        private AssetReferenceSprite cardReference;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //SetCardSprite(card);
        }

        public void SetCardSprite(Card cardface)
        {
            if (!isFaceUp)
            {
                cardReference = new AssetReferenceSprite(Constant.CardConstants.cardFolder + Constant.CardConstants.cardBack + Constant.CardConstants.spriteExtention);
            }
            else
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
            }
            
            cardReference.LoadAssetAsync().Completed += (result) =>
            {
                cardImage.sprite = result.Result;
            };


        }
    }
}

