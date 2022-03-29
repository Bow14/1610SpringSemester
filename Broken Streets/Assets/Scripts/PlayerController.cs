using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turningSpeed = 50.0f;
    public float verticalInput; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate((Vector3.left * turningSpeed * verticalInput * Time.deltaTime));
    }
}
