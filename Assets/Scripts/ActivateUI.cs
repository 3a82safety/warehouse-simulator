using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateUI : MonoBehaviour
{
    public GameObject UIPanel;
    public static ActivateUI instance;
    // Start is called before the first frame update
    public void ActiveUI()
    {
        UIPanel.SetActive(true);
    }

    // Update is called once per frame
    private void Awake()
    {
       instance = this; 
    }
}
