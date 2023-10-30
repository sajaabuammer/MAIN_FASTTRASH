using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundEerie : MonoBehaviour
{
    public AudioClip mySound;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(mySound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
