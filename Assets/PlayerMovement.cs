using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    public float Forwardforce = 2000;
    public float Rightforce = 500;
    public float Backforce = 500;
    public float upwardforce = 500;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate() // Fixed update because we messing with Unity physics
    {
        if (Input.GetKey("w"))
        {
            // rb.AddForce(Rightforce * Time.deltaTime, 0, 0 ,ForceMode.VelocityChange);
            rb.AddForce(0, 0, Forwardforce * Time.deltaTime);
        }
        // 

        //here time delta time used for the different machines have different frame rate the higher the frame rate lower the values we will get 
        else if (Input.GetKey("d"))
        {
            // rb.AddForce(Rightforce * Time.deltaTime, 0, 0 ,ForceMode.VelocityChange);
            rb.AddForce(Rightforce * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("a"))
        {
            // rb.AddForce(-Rightforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddForce(-Rightforce * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("s"))
        {
            // rb.AddForce(0, 0, -Backforce * Time.deltaTime, ForceMode.VelocityChange);
            rb.AddForce(0, 0, -Backforce * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            // rb.AddForce(-Rightforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddForce(0, upwardforce * Time.deltaTime, 0);
        }

    }

    void gameOver()
    {

    }



}
