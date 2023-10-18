using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SECONDTRIAL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Renderer>().material.color = new Color(0.0f, 0.5f, 0.2f, 0.9f);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0.2f, 0f, 0.9f);
        }
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Renderer>().material.color = new Color(0.2f, 0f, 0.5f, 0.9f);
        }
    }
}


