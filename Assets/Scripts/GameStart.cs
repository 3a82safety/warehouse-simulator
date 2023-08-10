using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject modeScreen;

    public void ControlModeScreen()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        modeScreen.SetActive(!modeScreen.activeSelf);
    }

    public void StartGame(Button button)
    {
        if (button.name == "AssessmentButton")
        {
            SceneManager.LoadScene("Assessment");
        }
        else
        {
            SceneManager.LoadScene("DexBad");
        }
    }
}
