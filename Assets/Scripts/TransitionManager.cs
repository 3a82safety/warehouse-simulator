using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    public void TransitionScene()
    {
        if (SceneManager.GetActiveScene().buildIndex < 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void LoadZen()
    {
        SceneManager.LoadScene("Zen");
    }

    public void LoadXH()
    {
        SceneManager.LoadScene("XiangHao");
    }

    public void LoadDex()
    {
        SceneManager.LoadScene("Dexter");
    }
}
