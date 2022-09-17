using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingVisibility : MonoBehaviour
{
    public GameObject[] BuildingParts;
    private int currTransparentLv;
    public Material houseTransparent;
    public Material houseOpaque;
    
    void Start()
    {
        currTransparentLv = BuildingParts.Length - 1;
        for (int i = 0; i < BuildingParts.Length - 1; i++)
        {
            ChangeVisibility(currTransparentLv, Visibility.opaque);
            
        }
        ChangeVisibility(currTransparentLv, Visibility.transparent);
        // CreateBuildingBlocks();
    }
    
    private void ChangeColor(int floor, Color color)
    {
        Renderer[] renderers = BuildingParts[floor].GetComponentsInChildren<Renderer>();
        foreach (Renderer renderer in renderers)
        {
            renderer.material.color = color;
        }
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
            renderer.material = visibility == Visibility.opaque ? houseOpaque : houseTransparent;
            // renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, transparency);
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

    private void CreateBuildingBlocks()
    {
        
        
        // We will have a total of 4 levels with 10 rooms each
        // ground floor
        // Create a new cube for the floor
        GameObject ground_floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground_floor.transform.localScale = new Vector3(1, 0.1f, 1);
        ground_floor.transform.position = new Vector3(0, 0, 0);
        ground_floor.transform.parent = transform;
        ground_floor.name = "Floor";
        
        // create the outer walls
        GameObject ground_floor_wall1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground_floor_wall1.transform.localScale = new Vector3(1, 1, 0.1f);
        ground_floor_wall1.transform.position = new Vector3(0, 0.5f, -0.5f);
        ground_floor_wall1.transform.parent = ground_floor.transform;
        ground_floor_wall1.name = "Wall1";
        
        GameObject ground_floor_wall2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground_floor_wall2.transform.localScale = new Vector3(1, 1, 0.1f);
        ground_floor_wall2.transform.position = new Vector3(0, 0.5f, 0.5f);
        ground_floor_wall2.transform.parent = ground_floor.transform;
        ground_floor_wall2.name = "Wall2";
        
        GameObject ground_floor_wall3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground_floor_wall3.transform.localScale = new Vector3(0.1f, 1, 1);
        ground_floor_wall3.transform.position = new Vector3(-0.5f, 0.5f, 0);
        ground_floor_wall3.transform.parent = ground_floor.transform;
        ground_floor_wall3.name = "Wall3";
        
        GameObject ground_floor_wall4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground_floor_wall4.transform.localScale = new Vector3(0.1f, 1, 1);
        ground_floor_wall4.transform.position = new Vector3(0.5f, 0.5f, 0);
        ground_floor_wall4.transform.parent = ground_floor.transform;
        ground_floor_wall4.name = "Wall4";
        
        // create the inner walls
        GameObject ground_floor_wall5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground_floor_wall5.transform.localScale = new Vector3(0.1f, 1, 0.5f);
        ground_floor_wall5.transform.position = new Vector3(-0.3f, 0.5f, 0);
        ground_floor_wall5.transform.parent = ground_floor.transform;
        ground_floor_wall5.name = "Wall5";
        
        GameObject ground_floor_wall6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground_floor_wall6.transform.localScale = new Vector3(0.1f, 1, 0.5f);
        ground_floor_wall6.transform.position = new Vector3(0.3f, 0.5f, 0);
        ground_floor_wall6.transform.parent = ground_floor.transform;
        ground_floor_wall6.name = "Wall6";
        
        GameObject ground_floor_wall7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground_floor_wall7.transform.localScale = new Vector3(0.5f, 1, 0.1f);
        ground_floor_wall7.transform.position = new Vector3(0, 0.5f, -0.3f);
        ground_floor_wall7.transform.parent = ground_floor.transform;
        ground_floor_wall7.name = "Wall7";
        
        GameObject ground_floor_wall8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ground_floor_wall8.transform.localScale = new Vector3(0.5f, 1, 0.1f);
        ground_floor_wall8.transform.position = new Vector3(0, 0.5f, 0.3f);
        ground_floor_wall8.transform.parent = ground_floor.transform;
        ground_floor_wall8.name = "Wall8";

    }
}

public enum Visibility
{
    invisible, transparent, opaque
}
