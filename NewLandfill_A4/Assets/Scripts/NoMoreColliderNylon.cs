using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMoreColliderNylon : MonoBehaviour
{
    public GameObject WOOL;
    public GameObject POLYESTER;
    public GameObject COTTON;
    public GameObject LEATHERFINAL;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(WOOL.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(WOOL.GetComponent<Collider>(), POLYESTER.GetComponent<Collider>());
        Physics.IgnoreCollision(POLYESTER.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(COTTON.GetComponent<Collider>(), POLYESTER.GetComponent<Collider>());
        Physics.IgnoreCollision(COTTON.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(COTTON.GetComponent<Collider>(), WOOL.GetComponent<Collider>());
        Physics.IgnoreCollision(LEATHERFINAL.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(LEATHERFINAL.GetComponent<Collider>(), WOOL.GetComponent<Collider>());
        Physics.IgnoreCollision(LEATHERFINAL.GetComponent<Collider>(), POLYESTER.GetComponent<Collider>());
        Physics.IgnoreCollision(LEATHERFINAL.GetComponent<Collider>(), COTTON.GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {

    }


}