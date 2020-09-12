using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health;
    public float Speed;
    public float XIncrement;
    public float MinWidth, MaxWidth;
    public Animator _animator;
    public Transform Pplayer;
    public float lefft = -1.53f;
    private Vector2 _targetPos = Vector2.zero;
    private void Start()
    {
        _targetPos = transform.position;
    }

    private void Update()
    {
      if (Vector3.Distance(transform.position, _targetPos) <0.1f)
        {
            _animator.SetBool("Right", false);
            _animator.SetBool("Left", false);
        }
        transform.position = Vector2.MoveTowards(transform.position, _targetPos, Speed * Time.deltaTime);

    }

    public void moveLeft (){
         if (_targetPos.x > MinWidth){
             _targetPos = new Vector2(_targetPos.x - XIncrement, _targetPos.y);
           _animator.SetBool("Left", true);
         }
         
    }
    public void moveRight (){
         if (_targetPos.x < MaxWidth){
            _targetPos = new Vector2(_targetPos.x + XIncrement, _targetPos.y);
            _animator.SetBool("Right", true);
         }
         
    }

    public void ApplyDamage(int damage)
    {
        Health -= damage;
        if(Health <= 0)
        Destroy(gameObject);
    }




}
