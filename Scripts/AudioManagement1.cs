
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AudioManagement1 : MonoBehaviour
{
    // public AudioClip otherClip;
    public AudioSource audio;
    //public AudioSource audio10;
    public GameObject fuelConfirmationButton;
    //public AudioClip weatherConfirmed;

    void Start()
    {
        //audio1 = GetComponent<AudioSource>();
        //weatherConfirmed = GetComponent<AudioClip>();
    }

    void Update()
    {
        if (!audio.isPlaying)
        {
            fuelConfirmationButton.SetActive(true);
            // audio1.clip = weatherConfirmed;
            //audio1.Play();

            //audioSource.clip = otherClip;
            //audioSource.Play();
        }

    }

}



