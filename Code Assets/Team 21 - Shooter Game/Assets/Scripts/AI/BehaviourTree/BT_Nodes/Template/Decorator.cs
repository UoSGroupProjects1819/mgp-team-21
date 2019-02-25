﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Decorator : Behaviour {
    protected Decorator(GameObject go) : base(go) { }
    protected Behaviour child;
    protected void AddChild(Behaviour _child)
    {
        child = _child;
    }
}
