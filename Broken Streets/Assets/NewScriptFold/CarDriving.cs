using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriving : MonoBehaviour
{
    public Vector3 left;
    public Vector3 right;
    public Rigidbody playerRB;
    public Vector3 forward;
    public Vector3 backward;


    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRB.AddRelativeForce(forward, ForceMode.Force);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRB.AddRelativeForce(backward, ForceMode.Force);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB.AddRelativeTorque(left, ForceMode.Acceleration);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRB.AddRelativeTorque(right, ForceMode.Acceleration);
        }
    }

//    private void OnCollisionEnter(Collision other)
//    {
//        GameObject.Find("Player");
//    }
}
