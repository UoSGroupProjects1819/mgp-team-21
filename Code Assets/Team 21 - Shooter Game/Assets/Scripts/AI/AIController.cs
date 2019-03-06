using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

    Behaviour BT;
    public float Health = 10f;

    void Start () {
        GameObject go = gameObject;
        BT   = InitTree(go);
        gameObject.GetComponent<Blackboard>().SetValue("Health", Health);
	}
	
	void FixedUpdate () {
        BT.Tick();
	}

    Behaviour InitTree(GameObject go)
    {
        IsAlive isAlive = new IsAlive(go); //Ensures character is alive before attempting to run any behaviours
        Sequencer movement = new Sequencer(go);
        FindPlayer find = new FindPlayer(go); //Checks how far away the player is and sets them as a target if nearby
        MoveToTarget move = new MoveToTarget(go); //Moves the character towards the target

        movement.AddChild(find);
        movement.AddChild(move);

        isAlive.AddChild(movement);
        return isAlive;
    }

    void OnTriggerEnter2D(Collider2D collision)
    //void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enemy Collision:" + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Health -= collision.gameObject.GetComponent<BulletController>().damage;
            gameObject.GetComponent<Blackboard>().SetValue("Health", Health);
        }
    }
}
