using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using UnityEngine;

[Serializable]
public class CollisionFilter
{
    [SerializeReference] 
    private List<ICollisionFilterCondition> _conditions;

    private ICollisionFilterContext _context;
    
    public void Init(ICollisionFilterContext context)
    {
        _context = context;
    }

    public bool Pass(Collision collision)
    {
        return _conditions.All(c => c.Pass(collision, _context));
    }
}
