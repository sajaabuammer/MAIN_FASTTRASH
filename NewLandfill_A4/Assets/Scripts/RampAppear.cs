using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampAppear : MonoBehaviour
{

    public GameObject ramp; // Assign the target GameObject to activate in the Unity Editor
    public GameObject A2DESTROY; // Assign the GameObject to destroy in the Unity Editor
    public GameObject ChemicalSign;
    public GameObject ChemicalSignTransparent;

    // Start is called before the first frame update
    void Start()
    {
        ramp.SetActive(false);
        ChemicalSignTransparent.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { // Check if the object to destroy is null (destroyed)
        if (A2DESTROY == null)
        {
            ramp.SetActive(true);
            Destroy(ChemicalSign);
            ChemicalSignTransparent.SetActive(true);
        }
    }
}
