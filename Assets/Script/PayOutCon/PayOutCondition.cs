﻿using UnityEngine;
using System;

namespace DealerSim.PayOutCon
{
    [Serializable]
    public abstract class PayOutCondition
    {
        [SerializeField]
        public float PayRatio;

        public abstract bool CheckPayOutCondition();
        public abstract void ConditionValidate();
    }
}