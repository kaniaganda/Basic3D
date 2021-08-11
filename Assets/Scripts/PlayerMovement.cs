using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // A reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    
    public float forwardForce = 2000f; // Unity sometimes wants "f" added for floats
    public float sidewaysForce = 500f;

    // FixUpdate used when adjusting physics in Unity
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if (Input.GetKey("d")) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
