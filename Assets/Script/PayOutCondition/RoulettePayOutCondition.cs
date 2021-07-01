using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RoulettePayOutCondition : PayOutCondition
{
    public override bool checkPayOutCondition() {
        return true;
    }
}
