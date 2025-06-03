using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SearchService;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float rotSpeed = 180f;

    [SerializeField] private Transform camTransform;
    
    void Start()
    {
        // camTransform = Camera.main.transform;
        // camTransform = GameObject.Find("Main Camera").transform;
    }

    
    void Update()
    {
        int way = 0;
        if (Input.GetKey(KeyCode.A))
        {
            way = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            way = 1;
        }
        
        camTransform.Rotate(new Vector3 (0, way * rotSpeed * Time.deltaTime,0));
    }
}
