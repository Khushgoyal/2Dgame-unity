using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    // these are the forces applied to cube to move 
    public float forwardForce = 900000f;
    public float sidewayForce = 50000f;

    

    // Start is called before the first frame update
   /* void Start()
    {
       Debug.Log("Hello World"); 
       rb.AddForce(0,200,500);
    }*/

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime,0,0, ForceMode.VelocityChange);

        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
            
        }
    }
}
