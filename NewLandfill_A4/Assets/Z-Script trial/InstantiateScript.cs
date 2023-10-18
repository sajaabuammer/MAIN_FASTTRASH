using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScript : MonoBehaviour
{
    public Rigidbody spherePrefab; public Transform placetoStart;

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Rigidbody newInstance;
            newInstance = Instantiate(spherePrefab, placetoStart.position, placetoStart.rotation);
            newInstance.AddForce(placetoStart.forward * 50);
        }
    }
}