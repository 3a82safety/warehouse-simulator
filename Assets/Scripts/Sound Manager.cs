using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider voiceSlider;
    public AudioSource bgMusic;

    void Start()
    {
        voiceSlider.value = bgMusic.volume;
    }
    public void SetBgMusicVolume()
    {
        bgMusic.volume = voiceSlider.value;
    }
}
