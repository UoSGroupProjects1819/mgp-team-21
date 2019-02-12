using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackboardFloat : BlackboardBase {
    public BlackboardFloat(float val) { value = val; }
    public float GetValue() { return value; }
    public void SetValue(float val) { value = val; }
    private float value;
}
