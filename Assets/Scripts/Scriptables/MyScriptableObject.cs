using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Scriptable Object", menuName = "Scriptables/MyScriptableObject", order = 1)]
public class MyScriptableObject : ScriptableObject
{
    public float value;
    public List<float> values = new List<float>();
    public GameObject prefabs;


    public void SpawnObject(Vector3 position)
    {
        
    }
}
