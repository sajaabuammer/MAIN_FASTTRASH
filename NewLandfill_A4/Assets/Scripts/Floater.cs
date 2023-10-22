using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{

    //public float degreesPerSecond = 15.0f;
    //public float amplitude = 0.5f;
    //public float frequency = 0.5f;


    //Vector3 posOffset = new Vector3();
    //Vector3 tempPos = new Vector3();

    public float floatSpeed = 3f; // Adjust the floating speed as needed
    public float floatStrength = 1f; // Adjust the floating strength as needed

    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        //posOffset = transform.position;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //tempPos = posOffset;
        //tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        //transform.position = tempPos;
        float horizontalFloat = startPos.x + Mathf.Sin(Time.time * floatSpeed) * floatStrength;

        // Update the object's position
        transform.position = new Vector3(horizontalFloat, transform.position.y, transform.position.z);
    
    }
}
