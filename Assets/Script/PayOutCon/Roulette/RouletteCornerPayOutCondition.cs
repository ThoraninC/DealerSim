using UnityEngine;

namespace DealerSim.PayOutCon.Roulette
{
    public class RouletteCornerPayOutCondition : RoulettePayOutConditionType
    {
        [SerializeField]
        private bool zero;
        [SerializeField]
        private bool doubleZero;
        [SerializeField]
        private int topLeftCorner;
        [SerializeField]
        private string fullCorner;

        public override void ConditionValidate()
        {
            if (zero && doubleZero)
            {
                fullCorner = "0-00-2";
                ChangeBetRatio(11);
            }
            else if (zero)
            {
                fullCorner = "0-1-2";
                ChangeBetRatio(11);
            }
            else if (doubleZero)
            {
                fullCorner = "00-2-3";
                ChangeBetRatio(11);
            }
            else if (topLeftCorner < 1)
            {
                topLeftCorner = 1;
                fullCorner = "1-2-4-5";
                ChangeBetRatio(8);

            }
            else if (topLeftCorner > 32)
            {
                topLeftCorner = 32;
                fullCorner = "32-33-35-36";
                ChangeBetRatio(8);

            }
            else if (topLeftCorner % 3 == 0)
            {
                topLeftCorner--;
                fullCorner = $"{topLeftCorner}-{topLeftCorner + 1}-{topLeftCorner + 3}-{topLeftCorner + 4}";
                ChangeBetRatio(8);
            }
            else
            {
                fullCorner = $"{topLeftCorner}-{topLeftCorner + 1}-{topLeftCorner + 3}-{topLeftCorner + 4}";
                ChangeBetRatio(8);
            }
        }

    }
}