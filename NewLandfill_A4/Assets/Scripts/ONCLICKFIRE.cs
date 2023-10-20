using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONCLICKFIRE : MonoBehaviour
{
    public ParticleSystem Fire1;
    public ParticleSystem Fire2;// Assign the Particle System in the Unity Editor
    public GameObject LetterA;
    public GameObject LetterS;
    public GameObject LetterL;
    public GameObject Rock;
    private bool hasStarted = false;
    public float delay = 2f;

    void Update()
    {
        // Check if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space) && !hasStarted)
        {
            // Start the particle system if it hasn't been triggered yet
            Fire1.Play();
            Fire2.Play();
            hasStarted = true; // Update the start status
            Destroy(LetterA, delay);
            Destroy(LetterS, delay);
            Destroy(LetterL, delay);
        }

        if (LetterA == null)
        {
            Destroy(Rock);
        }

    }

}


