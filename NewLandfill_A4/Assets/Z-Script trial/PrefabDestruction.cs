using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDestruction : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5.5f);
    }
}