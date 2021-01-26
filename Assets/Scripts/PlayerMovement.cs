using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ZForce = 2000f;
    public float XForce = 2000f;
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, ZForce * Time.deltaTime);
      
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -ZForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(XForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-XForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
