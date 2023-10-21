using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject Ground; // Reference to the ground object.

    public GameObject BigPile1;
    public GameObject BigPile2;
    public GameObject BigPile3;
    public GameObject BigPile4;
    public GameObject BigPile5;
    public GameObject BigPile6;
    public GameObject BigPile7;
    public GameObject BigPile8;

    public float fallSpeed = 1.0f; // Adjust the fall speed as needed.

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            MoveObjectsUnderGround(BigPile1);
            MoveObjectsUnderGround(BigPile2);
            MoveObjectsUnderGround(BigPile3);
            MoveObjectsUnderGround(BigPile4);
            MoveObjectsUnderGround(BigPile5);
            MoveObjectsUnderGround(BigPile6);
            MoveObjectsUnderGround(BigPile7);
            MoveObjectsUnderGround(BigPile8);
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
        targetPosition.y = -17f; // Adjust this value based on your ground's height.

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



