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

    public void UpdatePointsDisplay()
{
    if (pointText != null)
    {
        pointText.text = points.ToString() + " Points";
        Debug.Log("1 Point Added");
    }
    else
    {
        Debug.LogError("pointText is not assigned!");
    }
}



    public void AddPoints()
    {
        points++;
        Debug.Log("AddPoints Function Executed");
    }
}