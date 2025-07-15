using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MyAgent : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destination;
    
    public List<Transform> waypoints = new List<Transform>();
    private int currentIndex = 0;
    private Transform target;

    public MyScriptableObject scriptableObject;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
        //agent.SetDestination(destination.position);
        //agent.destination = destination;
        
        currentIndex = 0;
        target = waypoints[currentIndex];
        
        scriptableObject.SpawnObject(this.transform.position);
        scriptableObject.value = 85;

    }

    // Update is called once per frame
    void Update()
    {
        // agent.SetDestination(destination.position);
        //
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     agent.isStopped = !agent.isStopped;
        // }

        Trip();
    }

    private void Trip()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            GoToNextPoint();
        }

        agent.SetDestination(target.position);
    }

    private void GoToNextPoint()
    {
        if (currentIndex >= waypoints.Count - 1)
        {
            currentIndex = 0;
        }
        else
        {
            currentIndex++;
        }
        
        target = waypoints[currentIndex];
    }
}
