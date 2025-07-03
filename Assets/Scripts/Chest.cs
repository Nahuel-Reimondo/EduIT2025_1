using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class Chest : MonoBehaviour, Interacable
{
    private Animation myAnimation;

    private Coroutine currentCoroutine;

    [SerializeField] private bool isOpen = false; 
    void Start()
    {
        myAnimation = GetComponent<Animation>();
    }

    
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.E))
        // {
        //     Open();
        //     // myAnimation.Stop();
        //     // myAnimation.IsPlaying("ChestOpen");
        // }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(currentCoroutine);
            StopAllCoroutines();
        }
    }

    private void Open()
    {
        myAnimation.Play();
    }

    public void Interact()
    {
        //Open();
        currentCoroutine = StartCoroutine(DelayOpen());

        // Esto no!
        //DelayOpen();

    }

    IEnumerator DelayOpen()
    {
        if (isOpen)
        {
            yield break;
        }

        isOpen = true;
        print(Time.time);
        yield return new WaitForEndOfFrame();
        yield return new WaitForSeconds(5f);
        print(Time.time);
        Open();
        
        currentCoroutine = StartCoroutine(DelayClose());
    }

    IEnumerator DelayClose()
    {
        yield return new WaitForSecondsRealtime(10f);
        AnimationClip clip = myAnimation.GetClip("ChestClose");
        myAnimation.clip = clip;
        myAnimation.Play();
        print("Close!");
    }

    public float GetLastInteraction()
    {
        return 0;
    }
}
