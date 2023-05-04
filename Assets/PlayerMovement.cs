using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour // Unity's base component, we're creating our own
{

    public Rigidbody rb;
    public float sidewaysForce = 250f;

    public float forwardForce = 500f;

    // Called every 0.02 seconds to handle physics calculations
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Input.GetButtonDown("Horizontal"); // < 0 // (-1, left - 1, right)
        if(Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f) {
                FindObjectOfType<GameManager>().EndGame();
        }
    }


}
