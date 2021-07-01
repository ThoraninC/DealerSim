using UnityEngine;
[System.Serializable]
public abstract class PayOutCondition
{
    [SerializeField]
    public float PayRatio;

    public abstract bool checkPayOutCondition();
}
