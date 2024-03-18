using System;
using UnityEngine;

namespace DefaultNamespace
{
    public interface ICollisionFilterContext
    {
        bool IsPlayer(GameObject obj);
        bool CanBeDamagedByPlayer(GameObject obj);
    }
}