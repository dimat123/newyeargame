using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform SpawnPos;
    public GameObject House;
    public float TimeSpawn;

    void Start()
    {
        StartCoroutine(SpawnCD());
    }
    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds (TimeSpawn);
        Instantiate(House, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
