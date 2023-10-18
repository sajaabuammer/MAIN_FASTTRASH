using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public ParticleSystem confettiEmitter;
    void Start() { }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            confettiEmitter.Emit(30);
        }


    }
}