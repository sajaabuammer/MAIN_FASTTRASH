using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript2 : MonoBehaviour
{
    public GameObject Ground; // Reference to the ground object.

    public GameObject BigPile9;
    public GameObject BigPile10;
    public GameObject BigPile11;
    public GameObject BigPile12;
    public GameObject BigPile13;
    public GameObject BigPile14;
    public GameObject BigPile15;
    public GameObject BigPile16;
    public GameObject BigPile17;
    public GameObject BigPile18;
    public GameObject BigPile19;
    public GameObject BigPile20;
    public GameObject BigPile21;
    public GameObject BigPile22;
    public GameObject BigPile23;
    public GameObject BigPile24;
    public GameObject ChemRecSign;
    public GameObject Jug1;
    public GameObject Jug2;
    public GameObject Jug3;
    public GameObject Li;
    public GameObject ToxicGases;
    public GameObject BehindLetter;


    public float fallSpeed = 1.0f; // Adjust the fall speed as needed.

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            MoveObjectsUnderGround(BigPile9);
            MoveObjectsUnderGround(BigPile10);
            MoveObjectsUnderGround(BigPile11);
            MoveObjectsUnderGround(BigPile12);
            MoveObjectsUnderGround(BigPile13);
            MoveObjectsUnderGround(BigPile14);
            MoveObjectsUnderGround(BigPile15);
            MoveObjectsUnderGround(BigPile16);
            MoveObjectsUnderGround(BigPile17);
            MoveObjectsUnderGround(BigPile18);
            MoveObjectsUnderGround(BigPile19);
            MoveObjectsUnderGround(BigPile20);
            MoveObjectsUnderGround(BigPile21);
            MoveObjectsUnderGround(BigPile22);
            MoveObjectsUnderGround(BigPile23);
            MoveObjectsUnderGround(BigPile24);
            Destroy(ChemRecSign);
            Destroy(Jug1);
            Destroy(Jug2);
            Destroy(Jug3);
            Destroy(Li);
            Destroy(ToxicGases);
            Destroy(BehindLetter);
        }
    }

    void MoveObjectsUnderGround(GameObject obj)
    {
        if (obj != null && Ground != null)
        {
            StartCoroutine(FallObject(obj));
        }
    }

    IEnumerator FallObject(GameObject obj)
    {
        Vector3 startPosition = obj.transform.position;
        Vector3 targetPosition = obj.transform.position;
        targetPosition.y = -20f; // Adjust this value based on your ground's height.

        float journeyLength = Mathf.Abs(targetPosition.y - startPosition.y);
        float startTime = Time.time;
        float distanceCovered = 0;
        float journeyFraction = 0;

        while (journeyFraction < 1)
        {
            distanceCovered = (Time.time - startTime) * fallSpeed;
            journeyFraction = distanceCovered / journeyLength;
            obj.transform.position = Vector3.Lerp(startPosition, targetPosition, journeyFraction);
            yield return null; // Wait for the next frame.
        }
    }
}



