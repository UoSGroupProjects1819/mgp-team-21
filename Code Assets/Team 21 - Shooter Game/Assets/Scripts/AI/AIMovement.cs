using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour {

    Behaviour BT;

    void Start () {
        GameObject go = gameObject;
        BT   = InitTree(go);
	}
	
	void FixedUpdate () {
        BT.Tick();
	}

    Behaviour InitTree(GameObject go)
    {
        Sequencer root = new Sequencer(go);
        FindPlayer find = new FindPlayer(go);
        MoveToTarget move = new MoveToTarget(go);

        root.AddChild(find);
        root.AddChild(move);

        return root;
    }
}
