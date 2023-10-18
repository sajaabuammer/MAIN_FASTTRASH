using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROYFOUR : MonoBehaviour
{
    public GameObject IDESTROY;
    public GameObject I2CREATE;
    private bool hasDestroyed = false;

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