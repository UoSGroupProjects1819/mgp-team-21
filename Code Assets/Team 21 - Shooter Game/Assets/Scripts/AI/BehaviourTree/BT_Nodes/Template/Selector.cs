using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Composite {
    protected override Status Update()
    {
        while (true)
        {
            currentStatus = children[currentChild].Tick();
            if (currentStatus != Status.FAIL) return currentStatus;
            else if (++currentChild >= children.Count) return Status.FAIL;
        }
        return Status.ERROR;
    }
}
