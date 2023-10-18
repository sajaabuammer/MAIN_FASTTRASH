using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROY : MonoBehaviour
{
    public GameObject E1DESTROY;
    public GameObject E12CREATE;
    private bool hasDestroyed = false;

    void Start()
    {
        E12CREATE.SetActive(false);
    }

    void Update()
    {
        if (E1DESTROY == null && !hasDestroyed)
        {
            E12CREATE.SetActive(true);
            hasDestroyed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == E1DESTROY)
        {
            Destroy(other.gameObject);
        }
    }
}


