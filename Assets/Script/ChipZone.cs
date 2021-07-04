using UnityEngine;
using UnityEngine.UI;
using DealerSim.PayOutCon;

namespace DealerSim
{
    [ExecuteInEditMode]
    public class ChipZone : MonoBehaviour
    {
        [SerializeField]
        private Image chipPrefab = default;
        [SerializeReference]
        [SerializeReferenceButton]
        private PayOutCondition[] payOutConditions = default;
        [SerializeField]
        private Gambler[] stakeHolders = default;
        [SerializeField]
        private int[] stake = default;

        public void ResolvePayout()
        {
            foreach (PayOutCondition pay in payOutConditions)
            {
                if (pay.CheckPayOutCondition())
                {
                    if (stakeHolders.Length == stake.Length)
                    {
                        for (int i = 0; i < stakeHolders.Length; i++)
                        {
                            stakeHolders[i].getcash((int)(stake[i] * (pay.PayRatio + 1)));
                        }
                    }
                    break; //No Need To check other condition as early condition will get the priority
                }
            }
        }

        private void OnValidate()
        {
            foreach (PayOutCondition pay in payOutConditions)
            {
                pay.ConditionValidate();
            }
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}