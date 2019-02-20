using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : Behaviour {
    public MoveToTarget(GameObject go) : base (go) { }
	protected override Status TickBehaviour () {
        GameObject target = gameObject.GetComponent<Blackboard>().GetGameObject("target");
        float targetDistance = gameObject.GetComponent<Blackboard>().GetFloat("targetDistance");
        float weaponRange = 10; //arbitrary value until weapons are added
        while (targetDistance > weaponRange)
        {
            float x = target.transform.position.x - gameObject.transform.position.x;
            float y = target.transform.position.y - gameObject.transform.position.y;

            gameObject.transform.rotation = new Quaternion(0, 0, Mathf.Atan2(y, x) * Mathf.Rad2Deg, 1);

            gameObject.transform.position = new Vector3(gameObject.transform.position.x + x * Time.deltaTime, gameObject.transform.position.y + y * Time.deltaTime, 0);

            targetDistance = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));
        }

        return currentStatus;
	}
}
