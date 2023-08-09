using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public int points;
    public TMP_Text pointText;
    public static PointsManager instance;
    public Text scoreText;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        points = 10;
    }

    public void Update()
    {
        pointText.text = points.ToString() + " Points";
        scoreText.text = points.ToString() + " Points";
    }

    public void AddPoints()
    {
        points++;
        Debug.Log(points);
    }
}