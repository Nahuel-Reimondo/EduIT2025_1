using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMovement : MonoBehaviour
{
    public float speed = 10f;
    
    void Update()
    {
        //this.transform.Translate(transform.forward * speed * Time.deltaTime);
        //this.transform.Translate(transform.right * speed * Time.deltaTime, Space.Self);
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        
        // Vector3 newPos = this.transform.position;
        // newPos += Vector3.forward * speed * Time.deltaTime;
        // this.transform.position = newPos;
    }
}
