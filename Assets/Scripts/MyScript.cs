using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    private Rigidbody myRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!. This is the Start!");
        myRigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //print("This is the Update!");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.useGravity = true;
        }
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            myRigidbody.useGravity = false;
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        print("OnCollisionEnter -" + other.name);
    }

    private void OnCollisionExit(Collision other)
    {
        
    }

    private void OnCollisionStay(Collision other)
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        print("OnTriggerEnter -" + collision.name);
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private Enemy enemyPrefab;
    private void CreateEnemy()
    {
        Enemy enemy = Instantiate(enemyPrefab);
        enemy.onDeath += UIManagerSingleton.instance.UpdateKills;
        //enemy.onDeath.Invoke();
    }

}
