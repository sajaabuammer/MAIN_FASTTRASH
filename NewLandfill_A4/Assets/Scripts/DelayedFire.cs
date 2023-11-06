using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedFire : MonoBehaviour
{
    public ParticleSystem fire2;
    public GameObject LetterA;
    public GameObject LetterS;
    public GameObject LetterL;
    public GameObject rock;
    private float delayTime = 4.0f;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (fire2.isPlaying)
        {
            Destroy(LetterA);
            Destroy(LetterS);
            Destroy(LetterL);
            Destroy(rock, 4.0f);

        }
    }

}

