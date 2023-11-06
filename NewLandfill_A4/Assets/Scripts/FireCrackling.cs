using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCrackling : MonoBehaviour
{
    public AudioClip crackle;
    public ParticleSystem fire2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fire2.isPlaying)
        {
            GetComponent<AudioSource>().PlayOneShot(crackle);
        }
    }
}
