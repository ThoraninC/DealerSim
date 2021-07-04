using UnityEngine;

namespace DealerSim.PayOutCon.Roulette
{
    [System.Serializable]
    public class RouletteRemainderPayOutCondition : RoulettePayOutConditionType
    {
        [SerializeField]
        private int divider;
        [SerializeField]
        private int remainder;

        public override void ConditionValidate()
        {
            if (divider <= 0 || divider > 3)
            {
                divider = 2;
            }
            if (remainder > divider || divider < 0)
            {
                divider = 0;
            }

            ChangeBetRatio(divider - 1);
        }

    }


}
