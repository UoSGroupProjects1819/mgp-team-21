using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : Behaviour
{
    public float SearchRange = 100; //Range at which the enemy will detect the player

    protected override Status TickBehaviour()
    {
        GameObject player = Blackboard.GetGlobalGameObject("Player");
        
        float X = player.transform.position.x - transform.position.x;
        float Y = player.transform.position.y - transform.position.y;

        float distance = Mathf.Sqrt(Mathf.Pow(X, 2) + Mathf.Pow(Y, 2));

        if (distance <= SearchRange)
        {
            GetComponent<Blackboard>().SetValue("target", player);
            GetComponent<Blackboard>().SetValue("targetDistance", distance);
            currentStatus = Status.PASS;
        }
        else { currentStatus = Status.FAIL; }
        return currentStatus;
    }
}
