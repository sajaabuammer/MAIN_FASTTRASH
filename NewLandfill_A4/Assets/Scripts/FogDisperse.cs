using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogDisperse : MonoBehaviour
{
    public GameObject A2DESTROY; // Assign the specific GameObject to monitor in the Unity Editor
    public float fogDecreaseDuration = 1f; // Duration for the fog to dissipate completely
    private float originalFogDensity; // Store the original fog density
    private bool shouldDisperseFog = false;


    void Start()
    {
        originalFogDensity = RenderSettings.fogDensity;
    }

    void Update()
    {
        if (A2DESTROY == null && !shouldDisperseFog)
        {
            shouldDisperseFog = true;
            StartCoroutine(DecreaseFogDensity());
        }
    }
    IEnumerator DecreaseFogDensity()
    {
        float elapsedTime = 0f;
        float currentFogDensity = RenderSettings.fogDensity;

        while (elapsedTime < fogDecreaseDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / fogDecreaseDuration);
            RenderSettings.fogDensity = Mathf.Lerp(currentFogDensity, 0f, t);
            yield return null;
        }

        // Ensure that fog is completely removed at the end
        RenderSettings.fogDensity = 0f;
        RenderSettings.fog = false;
    }
}
