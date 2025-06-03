using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    
    private Vector3 move; 
    
    void Start()
    {
        
    }

    void Update()
    {
        //Reset movement
        move = Vector3.zero;
        
        //Z
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move.z += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move.z -= 1;
        }
        //X
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move.x += 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move.x -= 1;
        }
        
        //Translate
        // transform.Translate(
        //     move.normalized * speed * Time.deltaTime,
        //     Space.World
        // );
        
        //Override Position
        Vector3 myPos = transform.position;
        myPos += move.normalized * speed * Time.deltaTime;
        transform.position = myPos;

    }
}
