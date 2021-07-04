using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DicePayOutCondition : PayOutCondition
{
    public abstract int DiceSumCheck(Die[] dice);
    public abstract bool DiceFaceCheck(Die[] dice);
}
