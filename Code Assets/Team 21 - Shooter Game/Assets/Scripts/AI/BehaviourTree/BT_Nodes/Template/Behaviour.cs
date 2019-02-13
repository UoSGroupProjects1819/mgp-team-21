using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Behaviour {
    public enum Status
    {
        INVALID,
        PASS,
        FAIL,
        RUNNING,
        ERROR
    };
    protected virtual void onInit() { currentStatus = Status.RUNNING; }
    protected abstract Status TickBehaviour();
    protected virtual void onTerminate(Status status) { }
    protected Status currentStatus = Status.INVALID;
    public virtual Status Tick()
    {
        if (currentStatus == Status.INVALID) onInit();
        currentStatus = TickBehaviour();
        if (currentStatus != Status.RUNNING) onTerminate(currentStatus);
        return currentStatus;
    }
}
