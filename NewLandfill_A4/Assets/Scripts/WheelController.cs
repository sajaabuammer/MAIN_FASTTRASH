using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public AudioClip mySound;

    float rotSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) || CAVE2.GetButtonDown(CAVE2.Button.Button7))
        {
            this.rotSpeed = 2;
            GetComponent<AudioSource>().PlayOneShot(mySound);
        }

        transform.Rotate(0, 0, this.rotSpeed);
    }
}