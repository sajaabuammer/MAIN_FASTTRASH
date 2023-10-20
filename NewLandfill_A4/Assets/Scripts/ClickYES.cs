using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickYES : MonoBehaviour
{

    public GameObject rock;
    public GameObject instructions2;
    // Start is called before the first frame update
    void Start()
    {
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
            rock.SetActive(true);
            Destroy(instructions2);
        }
    }
}
