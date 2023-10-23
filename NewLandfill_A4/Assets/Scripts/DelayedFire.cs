using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedFire : MonoBehaviour
{
    public GameObject targetObject;
    public ParticleSystem system1;
    public ParticleSystem system2;
    public ParticleSystem system3;
    public ParticleSystem system4;
    public ParticleSystem system5;
    public GameObject LetterA;
    public GameObject LetterS;
    public GameObject LetterL;
    public AudioClip FireStarter;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || CAVE2.GetButtonDown(CAVE2.Button.Button5))
        {
            // Cast a ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit object is the target object
                if (hit.collider.gameObject == targetObject)
                {
                    StartCoroutine(Delays());
                    GetComponent<AudioSource>().PlayOneShot(FireStarter);
                }

            }
        }

        if (system2.isPlaying)
        {
            Destroy(LetterA);
            Destroy(LetterS);
            Destroy(LetterL);
            Destroy(targetObject);
        }

    }

    IEnumerator Delays()
    {

        system1.Play();
        yield return new WaitForSeconds(3);
        system2.Play();
        system3.Play();
        system4.Play();
        system5.Play();

    }
}

