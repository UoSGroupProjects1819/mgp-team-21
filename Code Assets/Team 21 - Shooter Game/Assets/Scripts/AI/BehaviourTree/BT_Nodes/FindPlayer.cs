using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : Behaviour {
    public FindPlayer(GameObject go) : base(go)
    {
        //gameObject = go;
    }
    public float SearchRange = 100; //Range at which the enemy will detect the player

    protected override Status TickBehaviour()
    {
        GameObject player = Blackboard.GetGlobalGameObject("Player");
        
        float X = player.transform.position.x - gameObject.transform.position.x;
        float Y = player.transform.position.y - gameObject.transform.position.y;

        float distance = Mathf.Sqrt(Mathf.Pow(X, 2) + Mathf.Pow(Y, 2));

        if (distance <= SearchRange)
        {
            gameObject.GetComponent<Blackboard>().SetValue("target", player);
            gameObject.GetComponent<Blackboard>().SetValue("targetDistance", distance);
            currentStatus = Status.PASS;
        }
        else { currentStatus = Status.FAIL; }
        return currentStatus;
    }
}
