using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Composite : Behaviour {
    protected List<Behaviour> children;
    protected int currentChild = 0;

    public void AddChild(Behaviour child)
    {
        children.Add(child);
    }

    public void RemoveChild(Behaviour child)
    {
        for(int i = 0; i < children.Count; i++)
        {
            if (children[i] == child)
            {
                children.RemoveAt(i);
            }
        }
    }

    public void ClearChildren()
    {
        children.Clear();
    }
}
