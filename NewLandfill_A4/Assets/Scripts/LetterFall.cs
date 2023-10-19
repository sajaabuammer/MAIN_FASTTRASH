using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterFall : MonoBehaviour
{
    //public GameObject LetterA;
    // public GameObject LetterS;
    public GameObject instructions1;
    private Rigidbody rbA;
    /// Start is called before the first frame update
    void Start()
    {
        rbA = GetComponent<Rigidbody>();
        if (rbA == null)
        {
            Debug.LogError("Rigidbody component not found. Please attach a Rigidbody component to the GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (instructions1 == null)
        {
            rbA.AddForce(Vector3.forward * 1f, ForceMode.Impulse);
        }
    }
}
