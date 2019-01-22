using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forwardForce = 2000f, sidewaysForce = 200f;
    private Rigidbody rb;
    bool moving = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        if (rb == null)
        {
            print("Rigidbody not found on player!");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (moving)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
            
    }

    private void OnCollisionEnter(Collision collision)
    {
        moving = !(collision.collider.CompareTag("Obstacle"));
    
    }
}
