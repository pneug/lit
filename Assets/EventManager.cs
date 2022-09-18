using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public MoveAgent agent;
    public MoveAgent agent2;
    public ArrowSpawner ArrowSpawner;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            agent.enabled = true;
            agent2.enabled = true;
            ArrowSpawner.StopSpawn();
        }
    }
}
