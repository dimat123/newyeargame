using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour , IBeginDragHandler, IDragHandler { 

    public GameObject pPlayer;
    public int Health;
    public float Speed;
    public float XIncrement;
    public float MinWidth, MaxWidth;
    public Animator _animator;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if ((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y)))
        {
            if(eventData.delta.x > 0)
            {

            }
        
        
        }



    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }
}
