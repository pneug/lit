using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float spawnRate = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnArrow", 0f, spawnRate);
    }
    
    private void SpawnArrow()
    {
        GameObject arrow = Instantiate(arrowPrefab, transform.position, transform.rotation, transform);
        print("Spawned arrow");
    }

    public void StopSpawn()
    {
        // stop the arrow spawning
        CancelInvoke("SpawnArrow");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
