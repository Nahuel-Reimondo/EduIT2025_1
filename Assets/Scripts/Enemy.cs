using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public UnityEvent onSpawn;
    
    public Action onDeath;
    public Action<int> onAddScore;
    
    
    void Start()
    {
        onDeath += UIManagerSingleton.instance.UpdateKills;
        onAddScore += UIManagerSingleton.instance.UpdateScore;
        
        
        onSpawn.AddListener(UIManagerSingleton.instance.UpdateKills);
    }

    private void OnEnable()
    {
        onSpawn?.Invoke();
    }

    void OnDisable()
    {
        onDeath -= UIManagerSingleton.instance.UpdateKills;
        
        onSpawn.RemoveAllListeners();
    }


    public string bulletsLayer = "Bullets";
    public int bulletsMaskIndex = 10;
    public LayerMask layerMask;
    private void OnTriggerEnter(Collider other) 
    {
        //print(other.gameObject.name);
        
        if (other.gameObject.layer != LayerMask.NameToLayer(bulletsLayer))
            return;
        
        Debug.Log("Hit with Bullets");
        //UIManagerSingleton.instance.UpdateKills();
        
        onAddScore?.Invoke(50);
        
        // if (onDeath != null)
        // {
        //     onDeath.Invoke();
        // }
        
        //onDeath?.Invoke();
        
        Destroy(this.gameObject);
        
        
        // if (other.gameObject.layer == LayerMask.NameToLayer(bulletsLayer))
        // {
        //     
        //     Destroy(this.gameObject);
        // }
        
        
        // if (other.gameObject.layer == bulletsMaskIndex)
        // {
        //     Debug.Log("Hit with Bullets");
        // }

        // if ((layerMask.value & (1 << other.transform.gameObject.layer)) > 0) 
        // {
        //     Debug.Log("Hit with Layermask");
        // }
        // else 
        // {
        //     Debug.Log("Not in Layermask");
        // }
    }
}
