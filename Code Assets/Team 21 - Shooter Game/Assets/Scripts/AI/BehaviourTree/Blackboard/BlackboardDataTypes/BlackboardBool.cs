using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackboardBool : BlackboardBase
{
    public BlackboardBool(bool val) { value = val; }
    public bool GetValue() { return value; }
    public void SetValue(bool val) { value = val; }
    private bool value;
}
