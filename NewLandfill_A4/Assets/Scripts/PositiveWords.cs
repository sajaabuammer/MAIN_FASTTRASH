using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositiveWords : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject Textile4;
    public GameObject POSTIVE1;
    public GameObject POSTIVE2;
    public GameObject POSTIVE3;
    public GameObject POSTIVE4;
    public GameObject POSTIVE5;
    public GameObject POSTIVE6;
    public GameObject summary;
    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component attached to Cloth1.
        rb = GetComponent<Rigidbody>();

        // Disable the Rigidbody's gravity initially.
        rb.useGravity = false;

        // Lock rotation and movement on the X and Z axes.
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ |
                        RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

        POSTIVE1.SetActive(false);
        POSTIVE2.SetActive(false);
        POSTIVE3.SetActive(false);
        POSTIVE4.SetActive(false);
        POSTIVE5.SetActive(false);
        POSTIVE6.SetActive(false);
        summary.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.useGravity == false && Textile4 == null)
        {
            POSTIVE1.SetActive(true);
            POSTIVE2.SetActive(true);
            POSTIVE3.SetActive(true);
            POSTIVE4.SetActive(true);
            POSTIVE5.SetActive(true);
            POSTIVE6.SetActive(true);
            summary.SetActive(true);
        }
    }
}
