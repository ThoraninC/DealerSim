using UnityEngine;
using DealerSim.Enumuration;

namespace DealerSim.PayOutCon.Roulette
{
    public class RouletteSplitPayOutCondition : RoulettePayOutConditionType
    {
        public enum SplitType
        {
            Horizontal,
            Vertical
        }

        [SerializeField]
        private SplitType splitType;
        [SerializeField]
        private int topsplit;
        [SerializeField]
        private int pair;

        public override void ConditionValidate()
        {
            switch (splitType)
            {
                case SplitType.Horizontal:
                    if (topsplit == (int)RouletteSpace.Zero)
                    {
                        if (pair != 1 && pair != 2)
                        {
                            pair = 1;
                        }
                    }
                    else if (topsplit == (int)RouletteSpace.DoubleZero)
                    {
                        if (pair != 2 && pair != 3)
                        {
                            pair = 2;
                        }
                    }
                    else if (topsplit > 33)
                    {
                        topsplit = 33;
                        pair = 36;
                    }
                    else if (topsplit < 1)
                    {
                        topsplit = 1;
                        pair = 4;
                    }
                    else
                    {
                        pair = topsplit + 3;
                    }
                    break;
                case SplitType.Vertical:
                    if (topsplit == (int)RouletteSpace.DoubleZero)
                    {
                        pair = (int)RouletteSpace.Zero;
                    }
                    else if (topsplit == (int)RouletteSpace.Zero)
                    {
                        pair = (int)RouletteSpace.DoubleZero;
                    }
                    else if (topsplit > 35)
                    {
                        topsplit = 35;
                        pair = 36;
                    }
                    else if (topsplit < 1)
                    {
                        topsplit = 1;
                        pair = 2;
                    }
                    else if (topsplit % 3 == 0)
                    {
                        topsplit--;
                        pair = topsplit + 1;
                    }
                    else
                    {
                        pair = topsplit + 1;
                    }
                    break;
            }
            ChangeBetRatio(17);
        }

    }
}