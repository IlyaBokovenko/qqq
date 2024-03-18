using UnityEngine;

namespace DefaultNamespace
{
    public class IsPlayerCondition : ICollisionFilterCondition
    {
        public bool Pass(Collision collision, ICollisionFilterContext context)
        {
            return context.IsPlayer(collision.gameObject);
        }
    }
}