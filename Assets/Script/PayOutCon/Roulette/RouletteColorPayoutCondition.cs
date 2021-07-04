using UnityEngine;
using System;
using DealerSim.Enumuration;

namespace DealerSim.PayOutCon.Roulette
{
    [Serializable]
    public class RouletteColorPayOutCondition : RoulettePayOutConditionType
    {
        [SerializeField]
        private RouletteColor rouletteColor;

        public override void ConditionValidate()
        {
            switch (rouletteColor)
            {
                case RouletteColor.black:
                    break;
                case RouletteColor.red:
                    break;
                case RouletteColor.green:
                    break;
                default:
                    rouletteColor = RouletteColor.green;
                    break;
            }

            ChangeBetRatio(2.0f);
        }

    }
}