using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToClick : MonoBehaviour
{
    public NavMeshAgent agent;
    
    Camera myCamera;
    
    void Awake()
    {
        myCamera = Camera.main;  
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            print("Mouse position" +  Input.mousePosition);
        }
        
        myCamera.ScreenToWorldPoint(Input.mousePosition);
        myCamera.WorldToScreenPoint(this.transform.position);

        // if (Input.GetMouseButton(0))
        // {
        //     Vector3 worldPosition = myCamera.ScreenToWorldPoint(Input.mousePosition);
        //     print(worldPosition);
        // }

        if (Input.GetMouseButton(1))
        {
            Vector3 viewportPosition = myCamera.ScreenToViewportPoint(Input.mousePosition);
            print(viewportPosition);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit hit;
            Ray myRay = myCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(myRay, out hit))
            {
                print(hit.collider.gameObject);
                agent.SetDestination(hit.point);
            }
        }

    }

    private void OnMouseDown()
    {
        print(this.name);
    }
}
