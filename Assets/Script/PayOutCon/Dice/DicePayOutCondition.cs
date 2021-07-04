using DealerSim.GamblingMedium;

namespace DealerSim.PayOutCon.DicePayOutCondition
{
    public abstract class DicePayOutCondition : PayOutCondition
    {
        public abstract int DiceSumCheck(Die[] dice);
        public abstract bool DiceFaceCheck(Die[] dice);
    }
}
