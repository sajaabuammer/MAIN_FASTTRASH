using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
    public float fogIncreaseDuration = 5f; // Duration for the fog to reach full density
    private float originalFogDensity; // Store the original fog density

    void Start()
    {
        originalFogDensity = RenderSettings.fogDensity;
        StartCoroutine(IncreaseFogDensity());
    }

    IEnumerator IncreaseFogDensity()
    {
        float elapsedTime = 5f;
        float currentFogDensity = RenderSettings.fogDensity;

        while (elapsedTime < fogIncreaseDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / fogIncreaseDuration);
            RenderSettings.fogDensity = Mathf.Lerp(currentFogDensity, originalFogDensity * 2f, t); // Adjust the multiplication factor as needed
            yield return null;
        }
    }
}
