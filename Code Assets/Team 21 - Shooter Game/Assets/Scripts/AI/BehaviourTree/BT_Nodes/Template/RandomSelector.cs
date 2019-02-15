using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSelector : Composite {
    public RandomSelector(GameObject go) : base(go) { }
    protected override Status TickBehaviour()
    {
        currentStatus = Update();
        return currentStatus;
    }

    Status Update()
    {
        List<Behaviour> behaviours = children;
        currentChild = Random.Range(0, behaviours.Count);
        currentStatus = behaviours[currentChild].Tick();
        if (currentStatus != Status.FAIL) return currentStatus;
        else
        {
            behaviours.RemoveAt(currentChild);
            if (behaviours.Count == 0) return Status.FAIL;
        }
        return currentStatus;
    }
}
