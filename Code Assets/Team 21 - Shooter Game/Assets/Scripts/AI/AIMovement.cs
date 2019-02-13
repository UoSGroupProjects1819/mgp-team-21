using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour {

    Behaviour BT;


    void Start () {
      BT   = InitTree();
	}
	
	void FixedUpdate () {
        BT.Tick();
	}

    Behaviour InitTree()
    {
        Sequencer root = new Sequencer();
        FindPlayer find = new FindPlayer();
        MoveToTarget move = new MoveToTarget();

        root.AddChild(find);
        root.AddChild(move);

        return root;
    }
}
