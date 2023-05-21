using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public GameObject settingsScr;
    public GameObject mainMenu;

    public void OpenSettings()
    {
        settingsScr.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void CloseSettings()
    {
        settingsScr.SetActive(false);
        mainMenu.SetActive(true);
    }
}
