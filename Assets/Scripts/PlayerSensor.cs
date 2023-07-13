using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSensor : MonoBehaviour
{
    public GameObject UI;
    
    void OnTriggerEnter(Collider PlayerEnters)
    {
        Debug.Log("Working!");
        UI.SetActive(true);
        
    }
}
