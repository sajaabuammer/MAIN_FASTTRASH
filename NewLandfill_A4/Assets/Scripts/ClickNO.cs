using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNO : MonoBehaviour 

{
    public GameObject instructions1;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseOver()
    {
        if (Input.GetButtonDown("Fire1"))

        {
            Destroy(instructions1);
        }
    }
}
