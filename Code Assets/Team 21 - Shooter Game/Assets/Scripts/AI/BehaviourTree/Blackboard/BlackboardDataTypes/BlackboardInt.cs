using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackboardInt : BlackboardBase {
    public BlackboardInt(int val) { value = val; }
    public int GetValue() { return value; }
    public void SetValue(int val) { value = val; }
    private int value;
}
