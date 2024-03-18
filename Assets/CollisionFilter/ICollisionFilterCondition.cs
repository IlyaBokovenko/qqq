using UnityEngine;

namespace DefaultNamespace
{
    public interface ICollisionFilterCondition
    {
        bool Pass(Collision collision, ICollisionFilterContext context);
    }
}