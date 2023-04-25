using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AudioHandler : MonoBehaviour
{

    public GameObject introPanel;

    public AudioSource siamsatireAudio;
    public AudioSource triskelAudio;
    public AudioSource cornerhouseAudio;

    public VideoPlayer siamsaVideo;
    public VideoPlayer triskelVideo;
    public VideoPlayer cornerhouseVideo;
    public GameObject playAgain;

    public Material siamsatireSkybox;
    public Material triskelSkybox;
    public Material cornerHouseSkybox;


    void Start()
    {
        introPanel.SetActive(true);
    }


    public void SiamsaTire()
    {
        cornerhouseAudio.mute = true;
        triskelAudio.mute = true;
        siamsatireAudio.mute = false;
        RenderSettings.skybox = siamsatireSkybox;
    }
    public void Triskel()
    {
        cornerhouseAudio.mute = true;
        triskelAudio.mute = false;
        siamsatireAudio.mute = true;
        RenderSettings.skybox = triskelSkybox;
    }

    public void Cornerhouse()
    {
        cornerhouseAudio.mute = false;
        triskelAudio.mute = true;
        siamsatireAudio.mute = true;
        RenderSettings.skybox = cornerHouseSkybox;
    }

    private void Update()
    {
        if (siamsaVideo.isPlaying && triskelVideo.isPlaying && cornerhouseVideo.isPlaying)
        {
            playAgain.SetActive(false);
        }

        else
        {
            playAgain.SetActive(true);
        }
    }
}
