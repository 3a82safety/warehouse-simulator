using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject soundSettingsScreen;
    public Transform camPos;

    //public Slider voiceSlider;
    //public AudioSource bgMusic;

    // Start is called before the first frame update
    void Start()
    {
       // voiceSlider.value = bgMusic.volume;
    }

    // Update is called once per frame
    void Update()
    {
        openSettingsScreen();
    }

    //public void SetBgMusicVolume()
    //{
    //    bgMusic.volume = voiceSlider.value;
    //}

    public void openSettingsScreen()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (soundSettingsScreen.activeSelf)
            {
                soundSettingsScreen.SetActive(false);
            }
            else
            {
                soundSettingsScreen.SetActive(true);

                soundSettingsScreen.transform.position = new Vector3(camPos.position.x, 1.5f, camPos.position.z);
                soundSettingsScreen.transform.eulerAngles = camPos.eulerAngles;
            }
        }
    }
}
