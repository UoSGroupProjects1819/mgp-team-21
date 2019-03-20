using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequencer : Composite {
    public Sequencer(GameObject go) : base(go) { }
    protected override Status TickBehaviour()
    {
        currentStatus = Update();
        return currentStatus;
    }

    Status Update()
    {
        for (int i = 0; i < children.Count; i++)
        {
            currentStatus = children[i].Tick();
            if (currentStatus != Status.PASS) break;
        }
        return currentStatus;
    }
}
