using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequencer : Composite {
    protected override Status Update()
    {
        while(true)
        {
            currentStatus = children[currentChild].Tick();
            if (currentStatus != Status.PASS) return currentStatus;
            if (++currentChild >= children.Count) return Status.PASS;
        }
        return Status.ERROR;
    }
}
