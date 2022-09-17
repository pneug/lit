using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingVisibility : MonoBehaviour
{
    public GameObject[] BuildingParts;
    private int currVisibility;
    
    void Start()
    {
        currVisibility = BuildingParts.Length - 1;
        for (int i = 0; i < BuildingParts.Length; i++)
        {
            BuildingParts[i].SetActive(i < currVisibility);
        }
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            if (currVisibility > 0)
            {
                BuildingParts[--currVisibility].SetActive(false);
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            if (currVisibility < BuildingParts.Length)
            {
                BuildingParts[currVisibility++].SetActive(true);
            }
        }
    }
}
