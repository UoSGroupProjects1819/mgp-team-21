using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Composite {
    protected override Status TickBehaviour()
    {
        currentStatus = Update();
        return currentStatus;
    }

    Status Update()
    {
        currentStatus = children[currentChild].Tick();
        if (currentStatus != Status.FAIL) return currentStatus;
        else if (++currentChild >= children.Count) return Status.FAIL;
        return currentStatus;
    }
}
