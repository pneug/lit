using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outlineScript : MonoBehaviour
{
    public GameObject a;

    Color basecolor;

    void Start()
    {
        if(gameObject.GetComponent<Outline>() != null) basecolor = gameObject.GetComponent<Outline>().OutlineColor;
        else
        {
            basecolor = new Vector4(0.08018869f, 0.9170366f, 1.0f);
        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Hand") && gameObject.GetComponent<Outline>() != null)
        {
            if (a == null) gameObject.GetComponent<Outline>().OutlineColor = new Color(1,1,1,1);
            if(a != null) a.GetComponent<Outline>().OutlineColor = new Color(1, 1, 1, 1);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("Hand") && gameObject.GetComponent<Outline>() != null)
        {
            if (a == null)  gameObject.GetComponent<Outline>().OutlineColor = new Color(1, 1, 1, 1);
            if (a != null) a.GetComponent<Outline>().OutlineColor = new Color(1, 1, 1, 1);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Hand") && gameObject.GetComponent<Outline>() != null)
        {
            // print(other.name);
            if (a == null) gameObject.GetComponent<Outline>().OutlineColor = basecolor;
            if (a != null) a.GetComponent<Outline>().OutlineColor = basecolor;
        }
    }
}
