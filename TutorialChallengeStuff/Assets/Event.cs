using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Event : MonoBehaviour
{
    //private UnityEvent soEvent;
    
    [SerializeField] private UnityEvent soEvent;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            soEvent.Invoke();
        }
    }
}
