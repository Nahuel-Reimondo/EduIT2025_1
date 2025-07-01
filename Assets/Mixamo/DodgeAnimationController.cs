using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DodgeAnimationController : MonoBehaviour
{
    [Header("Anim params")] [SerializeField]
    private string dodgeParam = "Dodge";
    
    public float dodgeCooldown = 0.2f;
    
    private Animator animator;
    private float lastDodgeTime;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && Time.time - lastDodgeTime > dodgeCooldown)
        {
            animator.SetTrigger(dodgeParam);
            lastDodgeTime = Time.time;
            
            animator.CrossFade();
        }

    }
}
