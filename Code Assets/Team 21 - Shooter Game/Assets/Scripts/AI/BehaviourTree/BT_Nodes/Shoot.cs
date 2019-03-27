using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Behaviour {

    public Shoot(GameObject go) : base(go)
    {
        gameObject.GetComponent<Blackboard>().SetValue("canShoot", true);
    }

    protected override Status TickBehaviour()
    {
        if (gameObject.GetComponent<Blackboard>().GetBool("canShoot"))
        {
            if (gameObject.GetComponent<Blackboard>().HasKey("target"))
            {
                GameObject target = gameObject.GetComponent<Blackboard>().GetGameObject("target");
                float targetDistance = gameObject.GetComponent<Blackboard>().GetFloat("targetDistance");
                if (/*(targetDistance >= gameObject.GetComponent<AIController>().weapon.minRange) && */(targetDistance <= gameObject.GetComponent<AIController>().weapon.maxRange))
                {
                    Vector3 shotDir = (target.transform.position - gameObject.transform.position).normalized;
                    gameObject.GetComponent<Blackboard>().SetValue("ShotX", shotDir.x);
                    gameObject.GetComponent<Blackboard>().SetValue("ShotY", shotDir.y);

                    gameObject.GetComponent<AIController>().weapon.Fire();
                    gameObject.GetComponent<Blackboard>().SetValue("canShoot", false);
                    gameObject.GetComponent<Blackboard>().SetValue("shotTimer", 0.0f);
                    currentStatus = Status.PASS;
                }
                else currentStatus = Status.FAIL;
            }
            else currentStatus = Status.FAIL;
        }
        else
        {
            gameObject.GetComponent<Blackboard>().SetValue("shotTimer", gameObject.GetComponent<Blackboard>().GetFloat("shotTimer") + Time.deltaTime);
            if (gameObject.GetComponent<Blackboard>().GetFloat("shotTimer") >= gameObject.GetComponent<AIController>().weapon.ShotTimer) gameObject.GetComponent<Blackboard>().SetValue("canShoot", true);
            currentStatus = Status.FAIL;
        }
        return currentStatus;
    }
}
