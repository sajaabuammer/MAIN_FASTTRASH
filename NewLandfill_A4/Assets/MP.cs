using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP : MonoBehaviour
{
    public Transform player;        // The player's transform.
    public float moveSpeed = 5.0f;  // Speed at which the object moves.
    public float detectionDistance = 5.0f; // The distance at which the object starts moving.
    public float maxHeight = 10.0f; // The maximum height the object can reach.

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
        Vector3 targetPosition = transform.position + Vector3.up * moveSpeed * Time.deltaTime;

        // Ensure the object doesn't move above the maximum height.
        targetPosition.y = Mathf.Min(targetPosition.y, originalPosition.y + maxHeight);

        // Move the object towards the new position.
        transform.position = targetPosition;
    }
}