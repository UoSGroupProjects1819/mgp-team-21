using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Decorator : Behaviour {
    protected Behaviour child;
    protected void AddChild(Behaviour _child)
    {
        child = _child;
    }
}
