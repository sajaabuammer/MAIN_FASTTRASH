using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROYTWO : MonoBehaviour
{
    public GameObject A1DESTROY;
    public GameObject A12CREATE;
    private bool hasDestroyed = false;

    void Start()
    {
        A12CREATE.SetActive(false);
    }

    void Update()
    {
        if (A1DESTROY == null && !hasDestroyed)
        {
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