using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSensors : MonoBehaviour
{
    public float maxDistance = 5f;
    public Transform sensorHolder;
    public LayerMask interactionMask;
    void Update()
    {
        Ray r = new Ray(sensorHolder.transform.position,
            sensorHolder.transform.forward);

        //bool hitSomething = Physics.Raycast(r, out RaycastHit hit, maxDistance);
        //bool hitSomething = Physics.Raycast(r, out RaycastHit hit, maxDistance, interactionMask);
        bool hitSomething = Physics.Raycast(r, out RaycastHit hit,
            maxDistance, interactionMask, QueryTriggerInteraction.Collide);
        
        if (hitSomething)
        {
            print(hit.collider.gameObject.name);
            // Chest chestScript = hit.collider.GetComponent<Chest>();
            //
            // if (chestScript != null)
            // {
            //     chestScript.Open();
            // }
            
            print(hit.collider.gameObject.name);
            Interacable interactable = hit.collider.GetComponent<Interacable>();

            if (interactable != null)
            {
                interactable.Interact();
            }
            
           
        }

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(sensorHolder.transform.position,
            sensorHolder.transform.forward * maxDistance);
        
        //Gizmos.DrawSphere(this.transform.position, maxDistance);
        //Gizmos.DrawWireSphere(this.transform.position, maxDistance);
        
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(this.transform.position, this.transform.position + this.transform.up);
    }
}
