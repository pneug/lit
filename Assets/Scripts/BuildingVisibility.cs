using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingVisibility : MonoBehaviour
{
    public GameObject[] BuildingParts;
    private int currTransparentLv;
    
    void Start()
    {
        currTransparentLv = BuildingParts.Length - 1;
        for (int i = 0; i < BuildingParts.Length - 1; i++)
        {
            ChangeVisibility(currTransparentLv, Visibility.opaque);
            
        }
        ChangeVisibility(currTransparentLv, Visibility.transparent);
    }

    private void ChangeVisibility(int floor, Visibility visibility)
    {
        if (floor < 0 || floor >= BuildingParts.Length)
        {
            return;
        }
        
        Renderer[] renderers = BuildingParts[floor].GetComponentsInChildren<Renderer>();
        float transparency = 0;
        if (visibility == Visibility.opaque)
        {
            transparency = 1;
        }
        else if (visibility == Visibility.transparent)
        {
            transparency = 0.3f;
        }
        foreach (Renderer renderer in renderers)
        {
            renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, transparency);
        }
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currTransparentLv > 0)
            {
                currTransparentLv--;
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.Four) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currTransparentLv < BuildingParts.Length)
            {
                currTransparentLv++;
            }
        }
        //ChangeVisibility(currTransparentLv + 1, Visibility.invisible);
        ChangeVisibility(currTransparentLv, Visibility.transparent);
        ChangeVisibility(currTransparentLv - 1, Visibility.opaque);
    }
}

public enum Visibility
{
    invisible, transparent, opaque
}
