using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : Behaviour {
    public MoveToTarget(GameObject go) : base (go) { }
	protected override Status TickBehaviour () {
        GameObject target = gameObject.GetComponent<Blackboard>().GetGameObject("target");
        float targetDistance = gameObject.GetComponent<Blackboard>().GetFloat("targetDistance");
        float speed = 5.5f; //Probably be a good idea to create a properties script to add this sort of data to the blackboard at some point. Works here for now though
        float weaponRange = 10; //arbitrary value until weapons are added
        float x = target.transform.position.x - gameObject.transform.position.x;
        float y = target.transform.position.y - gameObject.transform.position.y;
        while (targetDistance > weaponRange)
        {
            x = target.transform.position.x - gameObject.transform.position.x;
            y = target.transform.position.y - gameObject.transform.position.y;

            Debug.Log(targetDistance);

            gameObject.transform.rotation = new Quaternion(0, 0, Mathf.Atan2(y, x) * Mathf.Rad2Deg, 1);

            float X = x / targetDistance;
            float Y = y / targetDistance;

            gameObject.transform.position = new Vector3(gameObject.transform.position.x + X * Time.deltaTime * speed, gameObject.transform.position.y + Y * Time.deltaTime * speed, 0);

            targetDistance = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));
        }
        gameObject.GetComponent<Blackboard>().SetValue("targetDistance", Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2)));

        return currentStatus;
	}
}
