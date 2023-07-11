using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
    public Canvas UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider PlayerEntersTrigger)
    {
        if(PlayerEntersTrigger.tag == "Player")
        {
            Debug.Log("Working");
            UI.enabled = true;
        }
    }
}

