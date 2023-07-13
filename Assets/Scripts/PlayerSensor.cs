using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSensor : MonoBehaviour
{
    public GameObject UI;
    public Collider UITrigger;
    
    void OnTriggerEnter(Collider UITrigger)
    {
        Debug.Log("Working!");
        UI.SetActive(true);
        
    }
}
