using UnityEngine;
using DealerSim.Enumuration;

namespace DealerSim.PayOutCon.Roulette
{
    [System.Serializable]
    [ExecuteInEditMode]
    public class RoulettePayOutCondition : PayOutCondition
    {
        public RouletteSpace RouletteSpace { get; private set; }

        [SerializeReference]
        [SerializeReferenceButton]
        private RoulettePayOutConditionType conditionType = default;

        public override bool CheckPayOutCondition()
        {
            return true;
        }

        public override void ConditionValidate()
        {
            conditionType.betRatioChange += changeBetRatio;
            conditionType.ConditionValidate();
            conditionType.betRatioChange -= changeBetRatio;
        }

        public void setRouletteSpace(RouletteSpace space)
        {
            RouletteSpace = space;
        }

        public void changeBetRatio(float spaceBetRatio)
        {
            PayRatio = spaceBetRatio;
        }
    }
}