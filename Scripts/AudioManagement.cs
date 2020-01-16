
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AudioManagement : MonoBehaviour
{

    
   // public AudioClip otherClip;
    public AudioSource audio;
    //public AudioSource audio10;
    public GameObject weatherConfirmationButton;
    //public AudioClip weatherConfirmed;
    //public LevelChanger levelChanger;
    //levelChanger = new LevelChanger;


    void Start()
    {
        //audio1 = GetComponent<AudioSource>();
        //weatherConfirmed = GetComponent<AudioClip>();
        //public LevelChanger levelChanger;
    }

    void Update()
    {
        if (!audio.isPlaying)
        {
            //weatherConfirmationButton.SetActive(true);
            // audio1.clip = weatherConfirmed;
            //audio1.Play();

            //audioSource.clip = otherClip;
            //audioSource.Play();
            print("audio done");
            //levelChanger.fadeToNextLevel();
        }
        
    }

    
}



