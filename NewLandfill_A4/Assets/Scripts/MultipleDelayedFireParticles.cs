using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleDelayedFireParticles : MonoBehaviour
{
    public class ParticleSystemTrigger : MonoBehaviour
    {
        public GameObject Rock; // The specific GameObject to point at
        public ParticleSystem[] fireParticles; // Array of Particle Systems to trigger
        public float[] delays; // Delays for each Particle System

        private RaycastHit hit;

        void Update()
        {
            // Check if the spacebar is pressed
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Cast a ray from the camera to the target object
                if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
                {
                    // Check if the hit object is the target object
                    if (hit.collider.gameObject == Rock)
                    {
                        // Trigger Particle Systems with delays
                        for (int i = 0; i < fireParticles.Length; i++)
                        {
                            float currentDelay = delays[i];
                            ParticleSystem currentPS = fireParticles[i];
                            StartCoroutine(ShowParticleSystemWithDelay(currentPS, currentDelay));
                        }
                    }
                }
            }
        }

        private System.Collections.IEnumerator ShowParticleSystemWithDelay(ParticleSystem ps, float delay)
        {
            yield return new WaitForSeconds(delay);
            if (ps != null)
            {
                // Start emitting particles for the current Particle System
                ps.Play();
            }
        }
    }
}