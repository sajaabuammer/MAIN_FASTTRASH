using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public Renderer objectRenderer; // Assign the Renderer component of the object in the Unity Editor
    public Color highlightColor; // Set the highlight color in the Unity Editor
    private Color originalColor; // Store the original color of the object
    private bool isClicked = false;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }

    void OnMouseEnter()
    {
        if (!isClicked)
        {
            // Change the material color to the highlight color when the mouse hovers over the object
            objectRenderer.material.color = highlightColor;
        }
        
    }

    void OnMouseExit()
    {
        if (!isClicked)
        {
            // Revert the material color to the original color when the mouse stops hovering over the object
            objectRenderer.material.color = originalColor;
        }
    }

    void OnMouseDown()
    {
        isClicked = true;
        // Add your custom actions here for when the object is clicked
        objectRenderer.material.color = originalColor;
    }
}
