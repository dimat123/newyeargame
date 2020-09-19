using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseMove : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, -3, 0);
    }
}
