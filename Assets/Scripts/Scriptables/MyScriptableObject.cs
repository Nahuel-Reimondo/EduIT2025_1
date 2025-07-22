using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Scriptable Object", menuName = "Scriptables/MyScriptableObject", order = 1)]
public class MyScriptableObject : ScriptableObject
{
    public float value;
    public List<float> floats = new List<float>();
    public List<InfoClass> values = new List<InfoClass>();
    public GameObject prefab;

    public GameObject SpawnObject(Vector3 position)
    {
        return prefab;
    }
}

[System.Serializable]
public class InfoClass
{
    public string name;
    public string description;
    public float value;
    
    public void SuperMethod()
    {
    }
}
