using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterJUG : MonoBehaviour
{
    public Transform player;        // The player's transform.
    public float moveSpeed = 5.0f;  // Speed at which the object moves.
    public float detectionDistance = 5.0f; // The distance at which the object starts moving.

    private Vector3 originalPosition;
    private bool isMoving = false;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);

        if (distanceToPlayer < detectionDistance)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if (isMoving)
        {
            MoveUp();
        }
    }

    void MoveUp()
    {
        // Calculate the new position for the object.
        Vector3 targetPosition = originalPosition + Vector3.up;

        // Move the object towards the new position.
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    // Any other functionality specific to the WaterJUG can be added below.
    // Define variables and methods as needed.
    // ...
}