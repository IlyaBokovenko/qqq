using System;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class NotCondition : ICollisionFilterCondition
    {
        [SerializeReference]
        private ICollisionFilterCondition _condition;
        
        public bool Pass(Collision collision, ICollisionFilterContext context)
        {
            return !_condition.Pass(collision, context);
        }
    }
}