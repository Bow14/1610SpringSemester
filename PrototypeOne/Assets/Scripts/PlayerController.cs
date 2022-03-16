using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;

    public float turnspeed = 25f;
    public float horizontalInput;
    public float forwardInput;

    // Update is called once per frame
    void Update()
    {
        //players input
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // the code used to move the vehicle forward
        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnspeed);
        
        // transform.Translate(horizontalInput *turnspeed * Time.deltaTime * Vector3.right);
    }
}
