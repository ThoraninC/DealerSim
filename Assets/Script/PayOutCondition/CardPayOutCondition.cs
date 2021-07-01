using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardPayOutCondition : PayOutCondition
{
    public abstract int CardSumCheck();
    public abstract bool CardFaceCheck();
}
