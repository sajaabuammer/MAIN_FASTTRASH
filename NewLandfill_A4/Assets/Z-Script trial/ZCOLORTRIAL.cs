using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZCOLORTRIAL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

 void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                GetComponent<Renderer>().material.color = new Color(0.0f, 0.5f, 0.2f, 0.9f);
        }
            if (Input.GetKeyDown(KeyCode.M))
            {
                GetComponent<Renderer>().material.color = Color.magenta;
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
            }
        }
    }

