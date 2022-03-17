using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSping : MonoBehaviour
{
    public float rotateSpeed = 100.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.back * rotateSpeed *  Time.deltaTime);
    }
}
