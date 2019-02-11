using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Behaviour : MonoBehaviour {
    public enum Status
    {
        INVALID,
        PASS,
        FAIL,
        RUNNING,
        ERROR
    };
    protected virtual void onInit() { }
    protected abstract Status Update();
    protected virtual void onTerminate(Status status) { }
    protected Status currentStatus = Status.INVALID;
    public virtual Status Tick()
    {
        if (currentStatus == Status.INVALID) onInit();
        currentStatus = Update();
        if (currentStatus != Status.RUNNING) onTerminate(currentStatus);
        return currentStatus;
    }
}
