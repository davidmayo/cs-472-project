using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayOneShot : MonoBehaviour
{
    public AudioSource ASRain;
    public AudioSource ASBackgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        ASRain = gameObject.AddComponent<AudioSource>();
        ASBackgroundMusic = gameObject.AddComponent<AudioSource>();

    }


}
