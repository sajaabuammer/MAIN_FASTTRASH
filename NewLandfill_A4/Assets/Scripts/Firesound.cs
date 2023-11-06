using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firesound : MonoBehaviour
{
    public GameObject question1;
    public AudioClip firecrackle;
    // Start is called before the first frame update
    void Start()
    {
        if (!question1.activeSelf)
        {
            
            // Perform acti GetComponent<AudioSource>().PlayOneShot(mySound);ons if the object is inactive
            Debug.Log("The object is inactive");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
