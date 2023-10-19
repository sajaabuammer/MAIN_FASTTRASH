using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallIfDestroyed : MonoBehaviour
{
    public GameObject instructions1; // The object whose destruction triggers the falling

    private Rigidbody rb;
    private bool shouldFall = false;

    public Vector3 fallDirection = Vector3.right; // Change this to the desired falling direction

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (instructions1 == null && !shouldFall)
        {
            shouldFall = true;
            rb.isKinematic = false;
            rb.AddForce(fallDirection * 100f, ForceMode.Impulse);
        }
    }
}
