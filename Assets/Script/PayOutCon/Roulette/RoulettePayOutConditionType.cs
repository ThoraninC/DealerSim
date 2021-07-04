using System;

namespace DealerSim.PayOutCon.Roulette
{
    [Serializable]
    public abstract class RoulettePayOutConditionType
    {
        public abstract void ConditionValidate();
        public event System.Action<float> betRatioChange;

        public void ChangeBetRatio(float ratio)
        {
            betRatioChange.Invoke(ratio);
        }
    }
}