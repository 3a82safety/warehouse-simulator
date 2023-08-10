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

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        points = 0;
    }

    public void Update()
    {
        pointText.text = points.ToString() + " Points";
    }

    public void AddPoints()
    {
        points++;
        Debug.Log(points);
    }
}