using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
   [SerializeField]  float speed;

   [SerializeField] private float horsePower = 0;
   private Rigidbody playerRb;
    private  const float turnspeed = 25f;
    public float horizontalInput;
    public float forwardInput;
    [SerializeField] private GameObject centerOfMass;
    [SerializeField] private TextMeshProUGUI speedometerText;
    [SerializeField] private TextMeshProUGUI rpmText;
    [SerializeField] private float rpm;

    [SerializeField] private List<WheelCollider> allWheels;
    [SerializeField] private int wheelsOnGround;

    // Update is called once per frame
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    void FixedUpdate()
    {
        //players input
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // the code used to move the vehicle forward
        //transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnspeed);

        speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 2.237f);
        speedometerText.SetText("Speed:" + speed + "mph");

        rpm = Mathf.Round(speed % 30) * 40;
        rpmText.SetText("Rpm" + rpm);

        // transform.Translate(horizontalInput *turnspeed * Time.deltaTime * Vector3.right);
    }

    bool IsonGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider whell in allWheels)
        {
            if (whell.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }

        return false;
    }
}
