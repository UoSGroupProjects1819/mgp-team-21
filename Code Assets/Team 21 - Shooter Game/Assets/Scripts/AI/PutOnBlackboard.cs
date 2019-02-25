using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutOnBlackboard : MonoBehaviour {
	void Start () {
        Blackboard.SetGlobalValue(gameObject.name, gameObject);
	}
}
