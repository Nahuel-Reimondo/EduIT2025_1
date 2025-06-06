using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyPlayer : MonoBehaviour
{
    //[SerializeField] private Image myImage;
    [SerializeField] private TextMeshProUGUI myText;
    [SerializeField] private float speed = 10f;
    [Space]
    [SerializeField] private GameObject bulletOriginal;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private MyBullet lastBullet;
    
    private int shotsFired = 0;
    
    private Vector3 move; 
    
    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
        Shoot();
        
        UpdateUI();
    }

    private void UpdateUI()
    {
        myText.text = "Bullets Fired: " + shotsFired.ToString() +".";
    }

    private void MovePlayer()
    {
        //Reset movement
        move = Vector3.zero;
        
        // move.x = Input.GetAxisRaw("Horizontal") * speed;
        // move.x = Input.GetAxisRaw("Vertical") * speed;
        
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

    private void Shoot()
    {
        //KeyCode.Space
        if (Input.GetButtonDown("Jump"))
        {
            GameObject bullet = 
                Instantiate(bulletOriginal,bulletSpawn.position, bulletSpawn.rotation);
            //bullet.SetActive(true);
            //bullet.SetActive(false);

            lastBullet = bullet.GetComponent<MyBullet>();
            lastBullet.name = "Super Bullet";
            lastBullet.SeeBullet();
            
            shotsFired++;
            //shotsFired += 1;
        }
    }
}
