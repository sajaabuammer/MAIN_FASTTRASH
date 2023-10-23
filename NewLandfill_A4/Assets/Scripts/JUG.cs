using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUG : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject water;
    public GameObject liters1;

    // Start is called before the first frame update
    void Start()
    {
        water.SetActive(false);
        liters1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Check for mouse input
        if (Input.GetKeyDown(KeyCode.Space))  // 0 corresponds to the left mouse button
        {
            // first print statement for debugging
            //Debug.Log("mouse clicked");

            // Create a ray from the camera to the mouse cursor
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject == targetObject)
              
                water.SetActive(true);
                liters1.SetActive(true);
            }
        }
    }
}