using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : Behaviour {

	protected override Status TickBehaviour () {
        GameObject target = GetComponent<Blackboard>().GetGameObject("target");
        float targetDistance = GetComponent<Blackboard>().GetFloat("targetDistance");
        float weaponRange = 10; //arbitrary value until weapons are added
        while (targetDistance > weaponRange)
        {
            float x = target.transform.position.x - transform.position.x;
            float y = target.transform.position.y - transform.position.y;

            transform.rotation = new Quaternion(0, 0, Mathf.Atan2(y, x) * Mathf.Rad2Deg, 1);

            transform.position = new Vector3(x * Time.deltaTime, y * Time.deltaTime, 0);
        }

        return currentStatus;
	}
}
