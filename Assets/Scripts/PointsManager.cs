using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public int points;
    public TMP_Text pointText;

    void Start()
    {
        points = 0;
    }

    public void Update()
    {
        pointText.text = "You've gotten " + points.ToString() + " point(s)";
    }

    public void AddPoints()
    {
        points++;
        Debug.Log(points);
    }
}
