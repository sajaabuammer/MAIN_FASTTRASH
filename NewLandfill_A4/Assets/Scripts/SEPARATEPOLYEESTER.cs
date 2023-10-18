using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEPARATEPOLYEESTER : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform separationPoint; //Drag and drop the SeparationPoint GameObject here
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.M))
        { Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            print("the m was pressed\n");
            if(Physics.Raycast(ray, out hit))
            {
                GameObject selectedObject = hit.transform.gameObject;

                if(selectedObject.CompareTag("POLYEESTER"))
                {

                    //Assuming you have a reference to the selected object
                    Vector3 currentPosition = selectedObject.transform.position;
                    Vector3 newPosition = currentPosition - Vector3.right * 2f;
                    //Move 2 units to the left

                    Vector3 localMove = new Vector3(-2f, 0f, 0f);
                    //Move two units to the left in local space
                    selectedObject.transform.localPosition += localMove;

                    //Move the POLYEESTER to the new position
                    selectedObject.transform.position = newPosition;

                }
            }
        }
        
    }
}
