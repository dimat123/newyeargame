using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health;
    public float Speed;
    public float XIncrement;
    public float MinWidth, MaxWidth;


    private Vector2 _targetPos = Vector2.zero;
    private void Start()
    {
        _targetPos = transform.position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPos, Speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.D) && _targetPos.x < MaxWidth)
        {
            _targetPos = new Vector2(_targetPos.x + XIncrement, _targetPos.y);
        }
        else if (Input.GetKeyDown(KeyCode.A) && _targetPos.x > MinWidth)
        {
            _targetPos = new Vector2(_targetPos.x - XIncrement, _targetPos.y);
        }

    }

    public void ApplyDamage(int damage)
    {
        Health -= damage;
        if(Health <= 0)
        Destroy(gameObject);
    }




}
