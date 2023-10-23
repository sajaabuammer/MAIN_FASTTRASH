using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions1 : MonoBehaviour
{
    public GameObject instructions1;
    //public GameObject LetterA;
    //public GameObject LetterS;
    // Start is called before the first frame update
    void Start()
    {
        instructions1.SetActive(false);
        }

        // Update is called once per frame
        void Update() 
        {
       //if (instructions1 == null)
        {
            //LetterS.GetComponent<Rigidbody>().AddForce(transform.forward * 40f);
            //LetterA.GetComponent<Rigidbody>().AddForce(transform.forward * 40f);
        }
    }

        void OnMouseOver()
    { 
        if (Input.GetButtonDown("Fire1") || CAVE2.GetButtonDown(CAVE2.Button.Button3))

        {
        instructions1.SetActive(true);
        }

    }
}

