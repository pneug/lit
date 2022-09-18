using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move this camera with wasdqe and rotate with uio
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * 10;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * 10;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * 10;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * 10;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position -= transform.up * Time.deltaTime * 10;
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position += transform.up * Time.deltaTime * 10;
        }
        
        if (Input.GetKey(KeyCode.U))
        {
            transform.eulerAngles += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.I))
        {
            transform.eulerAngles += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.eulerAngles += new Vector3(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.eulerAngles += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.N))
        {
            transform.eulerAngles += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.M))
        {
            transform.eulerAngles += new Vector3(0, 0, -1);
        }
        
        
    }
}

// 2s clip transparency
// 2s clip firefighter arrives
// 2s clip arrows

// 20s building roof smoking

// show first route
// show second route
// show fire spreading

// script for full clip
// show route through building with intransparent building
// make building parts transparent
// fire spreads to staircase, as detected by thermometer
// another route is quickly needed
// show the firefighter go there
