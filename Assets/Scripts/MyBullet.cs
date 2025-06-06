using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBullet : MonoBehaviour
{
    public string name;
    
    [SerializeField] private float speed = 50f;

    private float lifeTime = 5f;
    private float timer = 0f;
    
    private void OnEnable()
    {
        Invoke( nameof(DestroyBullet), lifeTime);
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(DestroyBullet));
    }

    private void OnDestroy()
    {
        CancelInvoke(nameof(DestroyBullet));
    }

    void Update()
    {
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        // timer += Time.deltaTime;
        // if (timer >= lifeTime)
        // {
        //     Destroy(this.gameObject);
        // }
    }

    public void SeeBullet()
    {
        
    }
}
