using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Behaviour {

    public Shoot(GameObject go) : base(go) { }

    protected override Status TickBehaviour()
    {
        if (gameObject.GetComponent<Blackboard>().HasKey("target"))
        {
            GameObject target = gameObject.GetComponent<Blackboard>().GetGameObject("target");

            Vector3 shotDir = (target.transform.position - gameObject.transform.position).normalized;
            gameObject.GetComponent<Blackboard>().SetValue("ShotX", shotDir.x);
            gameObject.GetComponent<Blackboard>().SetValue("ShotY", shotDir.y);

            if (gameObject.GetComponent<Blackboard>().GetGameObject("Weapon"))
            {
                gameObject.GetComponent<AIController>().weapon.Fire();
                currentStatus = Status.PASS;
            }
            else currentStatus = Status.FAIL;
        }
        else currentStatus = Status.FAIL;
        return currentStatus;
    }
}
