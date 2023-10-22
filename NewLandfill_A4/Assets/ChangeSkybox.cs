using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyboxOnCollision : MonoBehaviour
{
    public Material[] skyboxes; // Array of skybox materials to cycle through.
    private int currentSkyboxIndex = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Polyester Hat"))
        {
            // Change the skybox material.
            RenderSettings.skybox = skyboxes[currentSkyboxIndex];

            // Increment the current index or loop back to the first skybox if we reach the end.
            currentSkyboxIndex = (currentSkyboxIndex + 1) % skyboxes.Length;
        }
    }
}
