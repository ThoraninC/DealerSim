using DealerSim.GamblingMedium;

namespace DealerSim.PayOutCon.CardPayOutCondition
{   
    public abstract class CardPayOutCondition : PayOutCondition
    {
        public abstract int CardSumCheck(Card[] cards);
        public abstract bool CardFaceCheck(Card[] cards);
    }
}

