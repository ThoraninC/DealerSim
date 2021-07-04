using UnityEngine;

namespace DealerSim.PayOutCon.Roulette
{
    [System.Serializable]
    public class RouletteIntervalPayOutCondition : RoulettePayOutConditionType
    {
        [SerializeField]
        private int startSpace;
        [SerializeField]
        private int endSpace;

        public override void ConditionValidate()
        {
            if (startSpace < 0)
            {
                startSpace = 0;
            }
            else if (startSpace > 36)
            {
                startSpace = 36;
            }

            if (endSpace < 0)
            {
                endSpace = 0;
            }
            else if (endSpace > 36)
            {
                endSpace = 36;
            }

            if (startSpace > endSpace)
            {
                startSpace = endSpace;
            }
            else
            {
                ChangeBetRatio((36 / (endSpace - startSpace + 1)) - 1);
            }
        }

    }
}