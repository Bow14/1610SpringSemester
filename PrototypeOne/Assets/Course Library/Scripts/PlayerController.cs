using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // the code used to move the vehicle forward
        transform.Translate(35* Time.deltaTime* Vector3.forward);
        
    }
}
