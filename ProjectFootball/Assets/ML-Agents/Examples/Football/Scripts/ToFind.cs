using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToFind : MonoBehaviour
{
    public GameObject objectToFind;

    void Start()
    {
        GameObject.FindGameObjectWithTag("border");
        Debug.Log(objectToFind.name);
    }

    
    
}
