
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class AudioVideoManagement : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    //Audio




    void Start()
    {
        Invoke("PlayVideo", 11);
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
    }

}