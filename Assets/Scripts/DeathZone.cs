using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<LightSwitch>();

        if (collision.gameObject.GetComponent<LightSwitch>().Sviet.activeSelf)
        {
            Debug.Log("2");
            SceneManager.LoadScene("LOX");
        }
    } 
}
