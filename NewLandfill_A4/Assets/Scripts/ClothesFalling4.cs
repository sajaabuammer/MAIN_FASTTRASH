﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesFalling4 : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject Textile4;
    // Reference to Textile1 in the Inspector.
    public GameObject Boat1;
    public GameObject Boat2;
    public GameObject WaterPlatform;
    public AudioClip mySound;
    public Material newSkybox;
    public GameObject placetextile;
    public GameObject Spin;
    public GameObject summary;
    public GameObject POSTIVE1;
    public GameObject POSTIVE2;
    public GameObject POSTIVE3;
    public GameObject POSTIVE4;
    public GameObject POSTIVE5;
    public GameObject POSTIVE6;
    void Start()
    {
        // Get the Rigidbody component attached to Cloth1.
        rb = GetComponent<Rigidbody>();

        // Disable the Rigidbody's gravity initially.
        rb.useGravity = false;

        // Lock rotation and movement on the X and Z axes.
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ |
                        RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        WaterPlatform.SetActive(false);
        Boat1.SetActive(false);
        Boat2.SetActive(false);
        placetextile.SetActive(true);
        Spin.SetActive(true);
        summary.SetActive(false);
        POSTIVE1.SetActive(false);
        POSTIVE2.SetActive(false);
        POSTIVE3.SetActive(false);
        POSTIVE4.SetActive(false);
        POSTIVE5.SetActive(false);
        POSTIVE6.SetActive(false);
    }

    void Update()
    {
        if (rb.useGravity == false && Textile4 == null)
        {
            // Enable gravity to make Cloth1 fall with normal speed.
            rb.useGravity = true;
            WaterPlatform.SetActive(true);
            GetComponent<AudioSource>().PlayOneShot(mySound);
            RenderSettings.skybox = newSkybox;
            Boat1.SetActive(true);
            Boat2.SetActive(true);
            placetextile.SetActive(false);
            Spin.SetActive(false);
            summary.SetActive(true);
            POSTIVE1.SetActive(true);
            POSTIVE2.SetActive(true);
            POSTIVE3.SetActive(true);
            POSTIVE4.SetActive(true);
            POSTIVE5.SetActive(true);
            POSTIVE6.SetActive(true);


        }
    }
}


