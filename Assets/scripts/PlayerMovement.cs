using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 50f;
    public float sidewaysHelpingForce = 0.1f;

    public bool pastFinishLine;

    private void Start()
    {
        rb.velocity = new Vector3(0, 0, -forwardForce);
    }

    void FixedUpdate()
    {
        if (pastFinishLine)
        {
            if (Math.Abs(transform.position.x) <= 0.5)
            {
                rb.isKinematic = true;
                rb.freezeRotation = true;
            }
            
            if (transform.position.x > 0)
            {
                rb.AddForce(-sidewaysForce * 0.01f * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (transform.position.x < 0)
            {
                rb.AddForce(sidewaysForce * 0.01f * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
            }

            return;
        }

        rb.AddForce(-transform.position.x * sidewaysHelpingForce * Time.fixedDeltaTime, 0, 0);

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(-sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w") || Input.GetKey("up") || Input.GetKey("space"))
        {
            if (transform.position.y <= 0.6f && transform.position.y >= 0.5f)
            {
                rb.AddForce(0, 100f * Time.fixedDeltaTime, 0, ForceMode.VelocityChange);
            }
        }

        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            if (transform.position.y > 1f)
            {
                rb.AddForce(0, -50f * Time.fixedDeltaTime, 0, ForceMode.VelocityChange);
            }
        }
    }

    public void PastFinishLine()
    {
        pastFinishLine = true;
    }
}
