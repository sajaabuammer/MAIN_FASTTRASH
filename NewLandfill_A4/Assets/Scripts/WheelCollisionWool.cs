using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelCollisionWool : MonoBehaviour
{
    public GameObject Textile1;
    /*public GameObject Textile2;
    public GameObject Textile3;
    public GameObject Textile4;
    public GameObject Textile5;*/

    private float currentRotation = 0f; // Current rotation of the wheel.
    private int rotations1 = 0; // Counter for rotations for Textile1.
    private int rotations2 = 0; // Counter for rotations for Textile2.
    private int rotations3 = 0; // Counter for rotations for Textile3.
    private int rotations4 = 0; // Counter for rotations for Textile4.
    private int rotations5 = 0; // Counter for rotations for Textile5.
    private int requiredRotations = 5; // Set the desired number of rotations.
    private int requiredRotations2 = 10; // Set the desired number of rotations.

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Textile2")
        {
            Textile1.transform.parent = transform;
        }
     /*   if (other.gameObject.tag == "Textile2")
        {
            Textile2.transform.parent = transform;
        }
        if (other.gameObject.tag == "Textile3")
        {
            Textile3.transform.parent = transform;
        }
        if (other.gameObject.tag == "Textile4")
        {
            Textile4.transform.parent = transform;
        }
        if (other.gameObject.tag == "Textile5")
        {
            Textile5.transform.parent = transform;
        }*/
    }

    private void Update()
    {
        // Calculate the current rotation of the wheel.
        float newRotation = transform.rotation.eulerAngles.z;

        // Check for a full rotation (360 degrees) for each textile.
        if (newRotation < currentRotation)
        {
            if(Textile1.transform.IsChildOf(transform)) { rotations1++;}
           /* if (Textile2.transform.IsChildOf(transform)) { rotations2++;}
            if (Textile3.transform.IsChildOf(transform)) { rotations3++;}
            if (Textile4.transform.IsChildOf(transform)) { rotations4++;}
            if (Textile5.transform.IsChildOf(transform)) { rotations5++;}*/
        }


        // Check if the required rotations have been reached for each textile and destroy them individually.
        if (rotations1 >= requiredRotations)
        {
            Destroy(Textile1);
            rotations1 = 0;
        }

       /* if (rotations2 >= requiredRotations2)
        {
            Destroy(Textile2);
            rotations2 = 0;
        }

        if (rotations3 >= requiredRotations)
        {
            Destroy(Textile3);
            rotations3 = 0;
        }

        if (rotations4 >= requiredRotations)
        {
            Destroy(Textile4);
            rotations4 = 0;
        }

        if (rotations5 >= requiredRotations)
        {
            Destroy(Textile5);
            rotations5 = 0;
        }*/

        // Update the current rotation value.
        currentRotation = newRotation;
    }
}
