using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DicePayOutCondition : PayOutCondition
{
    public abstract int DiceSumCheck();
    public abstract bool DiceFaceCheck();
}
