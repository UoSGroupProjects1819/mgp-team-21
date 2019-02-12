using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour {
    private Sequencer sequencer;

	void Start () {
        sequencer = gameObject.AddComponent<Sequencer>();
        FindPlayer find = gameObject.AddComponent<FindPlayer>();
        MoveToTarget move = gameObject.AddComponent<MoveToTarget>();
        sequencer.AddChild(find);
        sequencer.AddChild(move);
	}
	
	void FixedUpdate () {
        sequencer.Tick();
	}
}
