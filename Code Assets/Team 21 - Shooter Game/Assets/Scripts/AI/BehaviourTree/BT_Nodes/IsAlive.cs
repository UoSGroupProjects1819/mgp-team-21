using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAlive : Decorator {

    public IsAlive(GameObject go) : base(go) { }

    protected override Status TickBehaviour()
    {
        if (gameObject.GetComponent<Blackboard>().GetFloat("Health") > 0)
        {
            currentStatus = child.Tick();
            return currentStatus;
        }
        else
        {
            if (gameObject.activeInHierarchy) gameObject.SetActive(false);
            return Status.FAIL;
        }
    }
}
