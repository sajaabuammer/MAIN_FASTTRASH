using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollider : MonoBehaviour
{ 
    public GameObject WOOOL;
    public GameObject NYLLON;
    public GameObject COOTTON;
    public GameObject LEAATHER;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(WOOOL.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(WOOOL.GetComponent<Collider>(), NYLLON.GetComponent<Collider>());
        Physics.IgnoreCollision(NYLLON.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(COOTTON.GetComponent<Collider>(), NYLLON.GetComponent<Collider>());
        Physics.IgnoreCollision(COOTTON.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(COOTTON.GetComponent<Collider>(), WOOOL.GetComponent<Collider>());
        Physics.IgnoreCollision(LEAATHER.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(LEAATHER.GetComponent<Collider>(), WOOOL.GetComponent<Collider>());
        Physics.IgnoreCollision(LEAATHER.GetComponent<Collider>(), NYLLON.GetComponent<Collider>());
        Physics.IgnoreCollision(LEAATHER.GetComponent<Collider>(),COOTTON.GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
