using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Slider voiceSlider;
    public AudioSource bgMusic;
    
    // Start is called before the first frame update
    void Start()
    {
        voiceSlider.value = bgMusic.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBgMuicVolume()
    {
        bgMusic.volume = voiceSlider.value;
    }
}
