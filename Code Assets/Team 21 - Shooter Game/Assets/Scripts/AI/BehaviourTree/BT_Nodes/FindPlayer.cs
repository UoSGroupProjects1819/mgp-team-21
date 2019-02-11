using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : Behaviour
{
    public float SearchRange = 100; //Range at which the enemy will detect the player
    List<GameObject> targetsInRange = new List<GameObject>();

    protected override Status Update()
    {
        currentStatus = Status.RUNNING;

        GameObject[] targets = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject target in targets)
        {
            float X = target.transform.position.x - transform.position.x;
            float Y = target.transform.position.y - transform.position.y;

            float distance = Mathf.Sqrt(Mathf.Pow(X, 2) + Mathf.Pow(Y, 2));

            if (distance <= SearchRange)
                if (!targetsInRange.Contains(target))
                    targetsInRange.Add(target);
        }
        currentStatus = Status.PASS;
        return currentStatus;
    }

    protected override void onTerminate(Status status)
    {
        targetsInRange.Clear();
    }
}
