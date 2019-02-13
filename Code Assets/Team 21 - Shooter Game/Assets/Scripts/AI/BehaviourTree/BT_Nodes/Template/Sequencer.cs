using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequencer : Composite {
    protected override Status TickBehaviour()
    {
        currentStatus = Update();
        return currentStatus;
    }

    Status Update()
    {
        currentStatus = children[currentChild].Tick();
        if (currentStatus != Status.PASS) return currentStatus;
        if (++currentChild >= children.Count) return Status.PASS;
        return currentStatus;
    }
}
