using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Composite : Behaviour {
    protected Composite(GameObject go) : base(go) { }
    protected List<Behaviour> children = new List<Behaviour>();
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
