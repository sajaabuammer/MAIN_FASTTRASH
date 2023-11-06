using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SounClothes : MonoBehaviour
{
    public AudioClip collisionSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collisionSound != null)
        {
            // Check if the relative velocity of the collision is strong enough
            if (collision.relativeVelocity.magnitude > 8f)
            {
                audioSource.PlayOneShot(collisionSound);
            }
        }
		
    }
}