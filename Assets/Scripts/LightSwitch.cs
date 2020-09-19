using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{

    public GameObject Sviet;
    
    void OnMouseDown()
    {
        Debug.Log("Smth touched");
        Sviet.SetActive(false);
    }
}

