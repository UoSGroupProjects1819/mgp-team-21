using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackboard : MonoBehaviour {
    Dictionary<string, BlackboardBase> blackboard = new Dictionary<string, BlackboardBase>();
    static Dictionary<string, BlackboardBase> globalBlackboard = new Dictionary<string, BlackboardBase>();
    
    public float GetFloat(string key)
    {
        BlackboardFloat _float = (BlackboardFloat)blackboard[key];
        return _float.GetValue();
    }
    public GameObject GetGameObject(string key)
    {
        BlackboardGameObject _GameObject = (BlackboardGameObject)blackboard[key];
        return _GameObject.GetValue();
    }
    public int GetInt(string key)
    {
        BlackboardInt _int = (BlackboardInt)blackboard[key];
        return _int.GetValue();
    }
    public void SetValue(string key, float val)
    {
        if (blackboard.ContainsKey(key))
        {
            try
            {
                BlackboardFloat _float = (BlackboardFloat)blackboard[key];
                _float.SetValue(val);
            }
            catch
            {
                Debug.Log("Key '" + key + "' already exists for incompatible data type");
            }
        }
        else
        {
            blackboard.Add(key, new BlackboardFloat(val));
        }
    }
    public void SetValue(string key, GameObject val)
    {
        if (blackboard.ContainsKey(key))
        {
            try
            {
                BlackboardGameObject _GameObject = (BlackboardGameObject)blackboard[key];
                _GameObject.SetValue(val);
            }
            catch
            {
                Debug.Log("Key '" + key + "' already exists for incompatible data type");
            }
        }
        else
        {
            blackboard.Add(key, new BlackboardGameObject(val));
        }
    }
    public void SetValue(string key, int val)
    {
        if (blackboard.ContainsKey(key))
        {

            try
            {
                BlackboardInt _int = (BlackboardInt)blackboard[key];
                _int.SetValue(val);
            }
            catch
            {
                Debug.Log("Key '" + key + "' already exists for incompatible data type");
            }
        }
        else
        {
            blackboard.Add(key, new BlackboardInt(val));
        }
    }

    public static float GetGlobalFloat(string key)
    {
        BlackboardFloat _float = (BlackboardFloat)globalBlackboard[key];
        return _float.GetValue();
    }
    public static GameObject GetGlobalGameObject(string key)
    {
        BlackboardGameObject _GameObject = (BlackboardGameObject)globalBlackboard[key];
        return _GameObject.GetValue();
    }
    public static int GetGlobalInt(string key)
    {
        BlackboardInt _int = (BlackboardInt)globalBlackboard[key];
        return _int.GetValue();
    }
    public static void SetGlobalValue(string key, float val)
    {
        if (globalBlackboard.ContainsKey(key))
        {
            try
            {
                BlackboardFloat _float = (BlackboardFloat)globalBlackboard[key];
                _float.SetValue(val);
            }
            catch
            {
                Debug.Log("Key '" + key + "' already exists for incompatible data type");
            }
        }
        else
        {
            globalBlackboard.Add(key, new BlackboardFloat(val));
        }
    }
    public static void SetGlobalValue(string key, GameObject val)
    {
        if (globalBlackboard.ContainsKey(key))
        {

            try
            {
                BlackboardGameObject _GameObject = (BlackboardGameObject)globalBlackboard[key];
                _GameObject.SetValue(val);
            }
            catch
            {
                Debug.Log("Key '" + key + "' already exists for incompatible data type");
            }
        }
        else
        {
            globalBlackboard.Add(key, new BlackboardGameObject(val));
        }
    }
    public static void SetGlobalValue(string key, int val)
    {
        if (globalBlackboard.ContainsKey(key))
        {
            try
            {
                BlackboardInt _int = (BlackboardInt)globalBlackboard[key];
                _int.SetValue(val);
            }
            catch
            {
                Debug.Log("Key '" + key + "' already exists for incompatible data type");
            }
        }
        else
        {
            globalBlackboard.Add(key, new BlackboardInt(val));
        }
    }
}
