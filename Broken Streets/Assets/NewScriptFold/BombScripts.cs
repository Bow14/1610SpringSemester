using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScripts : MonoBehaviour
{
    //public float speed = 5.0f;
    //private Rigidbody bombRB;
    
    // Start is called before the first frame update
    void Start()
    {
        //bombRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //bombRB.AddForce(Vector3.forward * speed);
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
