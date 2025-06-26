using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour , Interacable
{
    private Animation myAnimation;
    
    void Start()
    {
        myAnimation = GetComponent<Animation>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Open();
            // myAnimation.Stop();
            // myAnimation.IsPlaying("ChestOpen");
        }
    }

    private void Open()
    {
        myAnimation.Play();
    }

    public void Interact()
    {
        Open();
    }

    public float GetLastInteraction()
    {
        return 0;
    }
}
