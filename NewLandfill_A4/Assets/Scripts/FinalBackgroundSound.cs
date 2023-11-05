using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBackgroundSound : MonoBehaviour
{
    public GameObject Textile5; // Reference to Textile4 in the Inspector.
    public AudioClip myAudio; // The audio clip you want to play.

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // Create an AudioSource component.

        if (myAudio != null)
        {
            audioSource.clip = myAudio;
            audioSource.loop = true; // Set this to true if you want the audio to loop.
            audioSource.Play(); // Start playing the audio.
        }
        else
        {
            Debug.LogError("Audio clip is not assigned.");
        }
    }

    void Update()
    {
        // Check if Textile4 is destroyed and stop the audio.
        if (Textile5 == null)
        {
            audioSource.Stop();
        }
    }
}