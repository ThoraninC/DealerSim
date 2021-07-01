using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PayOutCondition
{
    public abstract float payRatio { get; protected set; }

    public abstract bool checkPayOutCondition();
}
