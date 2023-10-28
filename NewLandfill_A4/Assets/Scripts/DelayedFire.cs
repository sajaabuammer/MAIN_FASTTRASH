using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedFire : MonoBehaviour
{

    public ParticleSystem fire1;
    public ParticleSystem fire2;
    public ParticleSystem fire3;
    public ParticleSystem fire4;
    public ParticleSystem fire5;
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
        
        if (fire1.isPlaying)
        {
            fire2.Play();
            fire3.Play();
            fire4.Play();
            fire5.Play();

        }

        if (fire2.isPlaying)
        {
            Destroy(LetterA);
            Destroy(LetterS);
            Destroy(LetterL);
        }

    }

}

