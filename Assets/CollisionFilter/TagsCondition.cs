using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class TagsCondition : ICollisionFilterCondition
    {
        [SerializeField] 
        private List<string> _tags;
        
        public bool Pass(Collision collision, ICollisionFilterContext context)
        {
            return _tags.Contains(collision.gameObject.tag);
        }
    }
}