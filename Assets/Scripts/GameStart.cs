using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void StartGame()
    {
        // Loads the game scene when the "Start" button is clicked
        SceneManager.LoadScene("Dexter");
    }
}
