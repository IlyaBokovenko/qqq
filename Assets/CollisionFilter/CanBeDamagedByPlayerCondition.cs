using System;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class CanBeDamagedByPlayerCondition : ICollisionFilterCondition
    {
        public bool Pass(Collision collision, ICollisionFilterContext context)
        {
            return context.CanBeDamagedByPlayer(collision.gameObject);
        }
    }
}