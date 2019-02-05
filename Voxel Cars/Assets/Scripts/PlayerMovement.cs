using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public Transform player;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate ()
    {
        //float translation = Time.deltaTime * forwardForce;
        rb.AddForce(0, 0, Time.deltaTime * forwardForce);

        if (Input.GetKey("a"))
        {
            rb.AddForce(Time.deltaTime * -sidewaysForce, 0, 0, ForceMode.VelocityChange);
            if (player.eulerAngles.y > 330 || player.eulerAngles.y < 30)
            {
                player.eulerAngles = new Vector3
                    (0, player.eulerAngles.y - 1, 0);
            }
        }
        //else if (Input.GetKey("w"))
        //{
        // rb.AddForce(0, 0, Time.deltaTime * sidewaysForce);
        // }
        //else if (Input.GetKey("s"))
        //{
        // rb.AddForce(0, 0, Time.deltaTime * -sidewaysForce);
        //}
        else if (Input.GetKey("d"))
        {
            rb.AddForce(Time.deltaTime * sidewaysForce, 0, 0, ForceMode.VelocityChange);
            if (player.eulerAngles.y < 30 || player.eulerAngles.y > 330)
            {
                player.eulerAngles = new Vector3
                    (0, player.eulerAngles.y + 1, 0);
            }
        }
        //else if (Input.GetKey("space"))
        //{
        //if (player.position.y > 1)
        //{
        //rb.AddForce(0, 0, 0);
        //}
        // else
        //{
        //rb.AddForce(0, Time.deltaTime * 20000, 0);
        // }
        //}
        else
        {
            if (player.eulerAngles.y < 179 && player.eulerAngles.y > 2)
            {
                player.eulerAngles = new Vector3
                        (0, player.eulerAngles.y - 1, 0);
            }
            else if (player.eulerAngles.y >= 179 && player.eulerAngles.y < 358)
            {
                player.eulerAngles = new Vector3
                        (0, player.eulerAngles.y + 1, 0);
            }
        }
    }
}
