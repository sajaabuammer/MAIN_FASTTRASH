using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript3 : MonoBehaviour
{
    public GameObject Ground; // Reference to the ground object.

    public GameObject BigPile17;
    public GameObject BigPile18;
    public GameObject BigPile19;
    public GameObject BigPile20;
    public GameObject BigPile21;
    public GameObject BigPile22;
    public GameObject BigPile23;
    public GameObject LEATHERFINAL;

    public float fallSpeed = 1.0f; // Adjust the fall speed as needed.

    private bool hasDestroyed = false; // Declare and initialize hasDestroyed as a boolean variable.

    void OnTriggerEnter(Collider other)
    {
        if (LEATHERFINAL == null && !hasDestroyed)
        {
            MoveObjectsUnderGround(BigPile17);
            MoveObjectsUnderGround(BigPile18);
            MoveObjectsUnderGround(BigPile19);
            MoveObjectsUnderGround(BigPile20);
            MoveObjectsUnderGround(BigPile21);
            MoveObjectsUnderGround(BigPile22);
            MoveObjectsUnderGround(BigPile23);
            hasDestroyed = true; // Set hasDestroyed to true to prevent further calls in OnTriggerEnter.
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
