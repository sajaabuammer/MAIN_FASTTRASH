using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogIncrease : MonoBehaviour
{
    public GameObject LetterA;
    public float targetFogDensity = 0.04f; // Set the target fog density in the Unity Editor
    public float fogIncreaseDuration = 10f; // Duration for the fog to reach full density
    private float originalFogDensity; // Store the original fog density
    private bool shouldIncreaseFog = false; // Flag to determine whether to increase the fog density

    void Start()
    {
        originalFogDensity = RenderSettings.fogDensity;
    }

    void Update()
    {
        if (LetterA == null && !shouldIncreaseFog)
        {
            shouldIncreaseFog = true;
            StartCoroutine(IncreaseFogDensity());
        }
    }

    IEnumerator IncreaseFogDensity()
    {
        float elapsedTime = 0f;
        float currentFogDensity = RenderSettings.fogDensity;

        while (elapsedTime < fogIncreaseDuration && currentFogDensity < targetFogDensity)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / fogIncreaseDuration);
            RenderSettings.fogDensity = Mathf.Lerp(currentFogDensity, targetFogDensity, t);
            yield return null;
        }
    }
}
