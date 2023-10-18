using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONCLICKFIRE : MonoBehaviour
{
    public ParticleSystem targetParticleSystem;
    public ParticleSystem targetParticleSystem2;
    public float delay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (targetParticleSystem != null)

        if (!targetParticleSystem.isPlaying)
        {
            targetParticleSystem.Play();
        }

        if (targetParticleSystem2 != null)

            if (!targetParticleSystem2.isPlaying)
            {
                targetParticleSystem2.Play();
            }
        if (Input.GetMouseButtonDown(0))
        {
            // Call the function to play the particle system with a delay
            Invoke("PlayParticleWithDelay", 10);
        }

    }
}
