using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate this icon around the y axis
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * 50);
    }
}
