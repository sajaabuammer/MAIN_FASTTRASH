using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFloat : MonoBehaviour
{
    public float minHorizontalFloatSpeed = 1f;  // Minimum horizontal floating speed
    public float maxHorizontalFloatSpeed = 1f;  // Maximum horizontal floating speed
    public float minVerticalFloatSpeed = 1f;    // Minimum vertical floating speed
    public float maxVerticalFloatSpeed = 1f;    // Maximum vertical floating speed
    public float minFloatStrength = 0.5f;       // Minimum floating strength
    public float maxFloatStrength = 1f;         // Maximum floating strength

    private Vector3 startPos;
    private float randomHorizontalFloatSpeed;
    private float randomVerticalFloatSpeed;
    private float randomFloatStrength;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        randomHorizontalFloatSpeed = Random.Range(minHorizontalFloatSpeed, maxHorizontalFloatSpeed);
        randomVerticalFloatSpeed = Random.Range(minVerticalFloatSpeed, maxVerticalFloatSpeed);
        randomFloatStrength = Random.Range(minFloatStrength, maxFloatStrength);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalFloat = startPos.x + Mathf.Sin(Time.time * randomHorizontalFloatSpeed) * randomFloatStrength;
        float verticalFloat = startPos.y + Mathf.Sin(Time.time * randomVerticalFloatSpeed) * randomFloatStrength;

        // Update the object's position
        transform.position = new Vector3(horizontalFloat, verticalFloat, transform.position.z);
    }
}