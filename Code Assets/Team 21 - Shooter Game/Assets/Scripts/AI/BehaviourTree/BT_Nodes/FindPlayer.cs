using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : Behaviour
{
    public float SearchRange = 100; //Range at which the enemy will detect the player
    GameObject nearestTarget = null;
    float targetDistance;

    protected override Status Update()
    {
        currentStatus = Status.RUNNING;

        GameObject[] targets = GameObject.FindGameObjectsWithTag("Player");
        if (targets.Length == 0) return Status.FAIL;
        foreach (GameObject target in targets)
        {
            float X = target.transform.position.x - transform.position.x;
            float Y = target.transform.position.y - transform.position.y;

            float distance = Mathf.Sqrt(Mathf.Pow(X, 2) + Mathf.Pow(Y, 2));

            if (nearestTarget != null)
            {
                if (distance < targetDistance)
                {
                    nearestTarget = target;
                    targetDistance = distance;
                }
            }
            else
            {
                nearestTarget = target;
                targetDistance = distance;
            }
        }
        //push nearestTarget and targetDistance to blackboard
        currentStatus = Status.PASS;
        return currentStatus;
    }
}
