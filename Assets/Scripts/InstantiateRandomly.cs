using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRandomly : MonoBehaviour
{
    public Transform pos;

    public GameObject[] objectsToInstantiate;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InstantiateObject()
    {
        int n = Random.Range(0, objectsToInstantiate.Length);
        Instantiate(objectsToInstantiate[n], pos.position, objectsToInstantiate[n].transform.rotation);
    }
}
