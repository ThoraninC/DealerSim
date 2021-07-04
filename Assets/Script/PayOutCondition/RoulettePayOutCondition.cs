﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[ExecuteInEditMode]
public class RoulettePayOutCondition : PayOutCondition
{
    public RouletteSpace RouletteSpace { get; private set; }

    [SerializeReference]
    [SerializeReferenceButton]
    private RoulettePayOutConditionType conditionType = default;

    public RoulettePayOutCondition()
    {
        conditionType.betRatioChange += changeBetRatio;
    }

    public override bool CheckPayOutCondition()
    {
        return true;
    }

    public override void ConditionValidate()
    {
        conditionType.betRatioChange += changeBetRatio;
        conditionType.ConditionValidate();
        conditionType.betRatioChange -= changeBetRatio;
    }

    public void setRouletteSpace(RouletteSpace space)
    {
        RouletteSpace = space;
    }

    public void changeBetRatio(float spaceBetRatio)
    {
        PayRatio = spaceBetRatio;
    }
}

[System.Serializable]
public abstract class RoulettePayOutConditionType
{
    public abstract void ConditionValidate();
    public event System.Action<float> betRatioChange;

    public void ChangeBetRatio(float ratio)
    {
        betRatioChange.Invoke(ratio);
    }
}

[System.Serializable]
public class RouletteIntervalPayOutCondition : RoulettePayOutConditionType
{
    [SerializeField]
    private int startSpace;
    [SerializeField]
    private int endSpace;

    public override void ConditionValidate()
    {
        if (startSpace<0)
        {
            startSpace = 0;
        }
        else if (startSpace>36)
        {
            startSpace = 36;
        }

        if (endSpace < 0)
        {
            endSpace = 0;
        }
        else if (endSpace > 36)
        {
            endSpace = 36;
        }

        if (startSpace > endSpace)
        {
            startSpace = endSpace;
        }
        else
        {
            ChangeBetRatio((36/(endSpace-startSpace+1))-1);
        }
    }

}

[System.Serializable]
public class RouletteColorPayOutCondition : RoulettePayOutConditionType
{
    [SerializeField]
    private RouletteColor rouletteColor;

    public override void ConditionValidate()
    {
        switch (rouletteColor)
        {
            default:
                rouletteColor = RouletteColor.green;
                break;
        }

        ChangeBetRatio(2.0f);
    }

}

[System.Serializable]
public class RouletteRemainderPayOutCondition : RoulettePayOutConditionType
{
    [SerializeField]
    private int divider;
    [SerializeField]
    private int remainder;

    public override void ConditionValidate()
    {
        if (divider <= 0 || divider >3)
        {
            divider = 2;
        }
        if(remainder > divider || divider < 0)
        {
            divider = 0;
        }

        ChangeBetRatio(divider-1);
    }

}

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
                else if(topsplit == (int)RouletteSpace.DoubleZero)
                {
                    if (pair != 2 && pair != 3)
                    {
                        pair = 2;
                    }
                }
                else if(topsplit > 33)
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
                    pair = topsplit+1;
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

public class RouletteCornerPayOutCondition : RoulettePayOutConditionType
{
    [SerializeField]
    private bool zero;
    [SerializeField]
    private bool doubleZero;
    [SerializeField]
    private int topLeftCorner;
    [SerializeField]
    private string fullCorner;

    public override void ConditionValidate()
    {
        if (zero && doubleZero)
        {
            fullCorner = "0-00-2";
            ChangeBetRatio(11);
        }
        else if (zero)
        {
            fullCorner = "0-1-2";
            ChangeBetRatio(11);
        }
        else if (doubleZero)
        {
            fullCorner = "00-2-3";
            ChangeBetRatio(11);
        }
        else if (topLeftCorner < 1)
        {
            topLeftCorner = 1;
            fullCorner = "1-2-4-5";
            ChangeBetRatio(8);

        }
        else if (topLeftCorner > 32)
        {
            topLeftCorner = 32;
            fullCorner = "32-33-35-36";
            ChangeBetRatio(8);

        }
        else if (topLeftCorner % 3 == 0)
        {
            topLeftCorner--;
            fullCorner = $"{topLeftCorner}-{topLeftCorner+1}-{topLeftCorner+3}-{topLeftCorner+4}";
            ChangeBetRatio(8);
        }
        else
        {
            fullCorner = $"{topLeftCorner}-{topLeftCorner + 1}-{topLeftCorner + 3}-{topLeftCorner + 4}";
            ChangeBetRatio(8);
        }
    }

}
