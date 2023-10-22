using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AClick : MonoBehaviour
{ 
    public GameObject instructions2;
    public GameObject rock;

    // Start is called before the first frame update
    void Start()
    {

        instructions2.SetActive(false);
        rock.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseOver()
    {
        if (Input.GetButtonDown("Fire1"))
        { 
            instructions2.SetActive(true);
        }
    }
}
