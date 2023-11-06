using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROYFOUR : MonoBehaviour
{
    public GameObject IDESTROY;
    public GameObject I2CREATE;
    private bool hasDestroyed = false;
    public AudioClip click4;

    void Start()
    {
        I2CREATE.SetActive(false);
    }

    void Update()
    {
        if (IDESTROY == null && !hasDestroyed)
        {
            I2CREATE.SetActive(true);
            hasDestroyed = true;
            GetComponent<AudioSource>().PlayOneShot(click4);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == IDESTROY)
        {
            Destroy(other.gameObject);
        }
    }
}