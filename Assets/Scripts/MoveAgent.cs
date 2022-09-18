using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveAgent : MonoBehaviour
{
    public Vector3 relGoalLocation;
    public bool goalIsRel = true;
    
    public bool vanishOnArrive = false;
    
    public bool debug = false;
    
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if (goalIsRel) {
            agent.SetDestination(transform.position + relGoalLocation);
        } else {
            agent.SetDestination(relGoalLocation);
        }
    }

    private void Update()
    {
        if (debug)
        {
            print(transform.position);
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            if (goalIsRel) {
                agent.SetDestination(transform.position + relGoalLocation);
            } else {
                agent.SetDestination(relGoalLocation);
            }
        }
        
        if (vanishOnArrive)
        {
            if ((transform.position - relGoalLocation).magnitude <= 1f)
            {
                Destroy(gameObject);
            }
        }
    }
}
