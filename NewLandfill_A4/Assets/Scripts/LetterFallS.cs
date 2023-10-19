using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterFallS : MonoBehaviour
{
    ///public GameObject LetterA;
    // public GameObject LetterS;
    public GameObject instructions1;
    private Rigidbody rbS;
    /// Start is called before the first frame update
    void Start()
    {
        rbS = GetComponent<Rigidbody>();
        if (rbS == null)
        {
            Debug.LogError("Rigidbody component not found. Please attach a Rigidbody component to the GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (instructions1 == null)
        {
            rbS.AddForce(Vector3.back * 1f, ForceMode.Impulse);
        }
    }
}
