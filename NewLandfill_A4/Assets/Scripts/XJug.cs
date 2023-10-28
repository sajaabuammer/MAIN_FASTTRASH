using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XJug : MonoBehaviour
{
    public GameObject objectToAppear; // The object to appear upon trigger

    private void Start()
    {
        objectToAppear.SetActive(false); // Ensure the object is initially disabled
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            objectToAppear.SetActive(true); // Enable the object when the trigger is entered by the player
        }
    }
}