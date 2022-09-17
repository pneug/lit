using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingResizer : MonoBehaviour
{
    public bool leftControllerIsIn;
    public bool rightControllerIsIn;
    private Vector3 lastControllerPosLeft;
    private Vector3 lastControllerPosRight;
    private float lastControllerDist;

    // Update is called once per frame
    void Update()
    {
        Vector3 leftControllerPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        Vector3 rightControllerPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        float distance = (leftControllerPosition - rightControllerPosition).magnitude;
        
        if (true)//leftControllerIsIn && rightControllerIsIn)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger) && 
                OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
            {
                
                float distDiff = (distance - lastControllerDist) / 4;
                if (transform.localScale.x + distDiff > 0.01f && transform.localScale.x + distDiff < 1f)
                {
                    transform.localScale += new Vector3(distDiff, distDiff, distDiff);
                }
                {
                    transform.localScale += new Vector3(distDiff, distDiff, distDiff);
                }
                
                //transform.localPosition += (leftControllerPosition - lastControllerPosLeft + rightControllerPosition - lastControllerPosRight) / 2;
            }
            else if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
            {
                transform.localPosition += rightControllerPosition - lastControllerPosRight;
            }
            else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
            {
                transform.localPosition += leftControllerPosition - lastControllerPosLeft;
            }
            else
            {
                
            }
        }
        
        lastControllerPosLeft = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        lastControllerPosRight = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        lastControllerDist = distance;
    }
    
    //private void ActivateAgents()

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LeftController"))
        {
            leftControllerIsIn = true;
        }
        else if (other.gameObject.CompareTag("RightController"))
        {
            rightControllerIsIn = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("LeftController"))
        {
            leftControllerIsIn = false;
        }
        else if (other.gameObject.CompareTag("RightController"))
        {
            rightControllerIsIn = false;
        }
    }
}
