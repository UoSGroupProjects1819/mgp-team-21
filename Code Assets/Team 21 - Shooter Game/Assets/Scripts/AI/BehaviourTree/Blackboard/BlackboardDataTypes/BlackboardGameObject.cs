using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackboardGameObject : BlackboardBase {
    public BlackboardGameObject(GameObject val) { value = val; }
    public GameObject GetValue() { return value; }
    public void SetValue(GameObject val) { value = val; }
    private GameObject value;
}
