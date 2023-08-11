using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public static Objects instance;

    public GameObject wrongFront;
    public GameObject correctFront;
    public GameObject wrongBody;
    public GameObject correctBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        instance = this;
    }

    public void ObjectState()
    {
        wrongFront.SetActive(false);
		correctFront.SetActive(true);
        wrongBody.SetActive(false);
        correctBody.SetActive(true);
    }
}
