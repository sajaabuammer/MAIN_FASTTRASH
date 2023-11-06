﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROYTHREE : MonoBehaviour
{
    public GameObject E2DESTROY;
    public GameObject E22CREATE;
    public AudioClip click3;
    private bool hasDestroyed = false;

    void Start()
    {
        E22CREATE.SetActive(false);
    }

    void Update()
    {
        if (E2DESTROY == null && !hasDestroyed)
        {
            E22CREATE.SetActive(true);
            hasDestroyed = true;
            GetComponent<AudioSource>().PlayOneShot(click3);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == E2DESTROY)
        {
            Destroy(other.gameObject);
        }
    }
}