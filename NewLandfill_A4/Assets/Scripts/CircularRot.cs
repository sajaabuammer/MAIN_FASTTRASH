
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularRot : MonoBehaviour
{
    public GameObject lastWheel;
    public GameObject polyester; // Reference to the "Polyester" object.
    public float rotSpeed = 20.0f; // Adjust the speed as needed.

    void Update()
    {
        float angle = rotSpeed * Time.deltaTime;

        // Rotate the "Polyester" object around the "LastWheel" object.
        polyester.transform.RotateAround(lastWheel.transform.position, Vector3.up, angle);
    }
}
