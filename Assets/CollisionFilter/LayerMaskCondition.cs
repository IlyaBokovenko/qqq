using System;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class LayerMaskCondition : ICollisionFilterCondition
    {
        [SerializeField]
        private LayerMask _mask;
        public bool Pass(Collision collision, ICollisionFilterContext context)
        {
            return ((1 << collision.gameObject.layer) & _mask) != 0;
        }
    }
}