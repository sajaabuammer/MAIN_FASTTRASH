using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POLYESTER : MonoBehaviour
{
    public GameObject LastWheel;
    public int speed;
    private Vector3 axis = Vector3.up;
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(LastWheel.transform.position, axis, speed * Time.deltaTime);
    }
}