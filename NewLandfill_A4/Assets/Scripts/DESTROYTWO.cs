using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROYTWO : MonoBehaviour
{
    public GameObject A1DESTROY;
    public GameObject A12CREATE;
    private bool hasDestroyed = false;
    public AudioClip click2;

    void Start()
    {
        A12CREATE.SetActive(false);
    }

    void Update()
    {
        if (A1DESTROY == null && !hasDestroyed)
        {
            GetComponent<AudioSource>().PlayOneShot(click2);
            A12CREATE.SetActive(true);
            hasDestroyed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == A1DESTROY)
        {
            Destroy(other.gameObject);
        }
    }
}