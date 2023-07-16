using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public int points;
    public Text pointText;

    void Start()
    {
        points = 0;
    }

    public void Update()
    {
        pointText.text = points.ToString() + " points!";
    }

    public void AddPoints()
    {
        points++;
        Debug.Log(points);
    }
}
