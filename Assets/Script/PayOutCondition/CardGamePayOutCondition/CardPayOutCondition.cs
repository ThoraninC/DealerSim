using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardPayOutCondition : PayOutCondition
{
    public abstract int CardSumCheck(Card[] cards);
    public abstract bool CardFaceCheck(Card[] cards);
}
