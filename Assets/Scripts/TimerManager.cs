using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    public float timeLeft;
    public bool timerOn = false;
    float minutes;
    float seconds;
    string secondsText;

    public TMP_Text timeText;
    public Button startButton;
    public GameObject timesUpScreen;
    public Transform camPos;

    float timeOver = 0;

    private void Start()
    {
        startButton.onClick.AddListener(delegate { timerOn = true; });
    }
    void Update()
    {
        if (timerOn)
        {
            UpdateTimer();
        }
       
    }

    public void UpdateTimer()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Time's up!");
            timerOn = false;
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            timesUpScreen.SetActive(true);

            timesUpScreen.transform.position = new Vector3(camPos.position.x, 1.5f, camPos.position.z);
            timesUpScreen.transform.localEulerAngles = camPos.localEulerAngles;
            timeText.gameObject.SetActive(false);

            Invoke("ChangeScene", 5f);
        }

        minutes = Mathf.Floor(timeLeft / 60);

        if (timeLeft >= 60)
        {
            seconds = Mathf.Floor(timeLeft) % 60;
        }
        else
        {
            seconds = Mathf.Floor(timeLeft);
        }

        if (seconds < 10)
        {
            secondsText = "0" + seconds;
        }
        else
        {
            secondsText = seconds.ToString();
        }

        timeText.text = "Time Left : " + minutes + ":" + secondsText;
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("MenuScene");
    }


}
