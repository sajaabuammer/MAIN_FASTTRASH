using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesFalling4 : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject Textile4; // Reference to Textile1 in the Inspector.

    void Start()
    {
        // Get the Rigidbody component attached to Cloth1.
        rb = GetComponent<Rigidbody>();

        // Disable the Rigidbody's gravity initially.
        rb.useGravity = false;

        // Lock rotation and movement on the X and Z axes.
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ |
                        RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    void Update()
    {
        if (rb.useGravity == false && Textile4 == null)
        {
            // Enable gravity to make Cloth1 fall with normal speed.
            rb.useGravity = true;
        }
    }
}
