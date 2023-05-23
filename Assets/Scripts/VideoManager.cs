using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    [SerializeField] VideoPlayer videoplayer;
    [SerializeField] GameObject RawImage;
    [SerializeField] AudioSource Music;




        void Start()
    {
        videoplayer = GetComponent<VideoPlayer>();
        videoplayer.loopPointReached += CheckOver;
    }


    public void PlayVideo(VideoClip other)
    {
        Music.Pause();
        RawImage.gameObject.SetActive(true);
        videoplayer.clip = other;
        videoplayer.Play();
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        Debug.Log("Video Is Over");
        Music.UnPause();
        RawImage.gameObject.SetActive(false);
        videoplayer.clip = null;
    }



}
