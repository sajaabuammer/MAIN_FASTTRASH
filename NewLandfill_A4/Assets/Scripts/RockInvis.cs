using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockInvis : MonoBehaviour
{
    public GameObject rock;
    public GameObject question2;

    // Start is called before the first frame update
    void Start()
    {
        rock.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (question2 == null)
        {
           rock.SetActive(true);
           Debug.Log("The object has been destroyed");
        }
    }
}
