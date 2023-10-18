using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROYFIVE : MonoBehaviour
{
    public GameObject A2DESTROY;
    public GameObject A22CREATE;
    private bool hasDestroyed = false;

    void Start()
    {
        A22CREATE.SetActive(false);
    }

    void Update()
    {
        if (A2DESTROY == null && !hasDestroyed)
        {
            A22CREATE.SetActive(true);
            hasDestroyed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == A2DESTROY)
        {
            Destroy(other.gameObject);
        }
    }
}
