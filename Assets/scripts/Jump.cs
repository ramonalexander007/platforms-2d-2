using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    public float force = 200;
    public float force_air = 100;
    public int jumps_max = 2;
    int jumps;
    GroundDetection_Raycast ground;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        ground= GetComponent<GroundDetection_Raycast>();
    }

    // Update is called once per frame
    void Update()
    {

        if (ground.grounded)
        {
            jumps = jumps_max;
        }

        if(Input.GetButtonDown("Jump") && jumps>0)
        {
            jumps--;
            if (ground.grounded)
            {
                rb.AddForce(new Vector2(0, force));
            }
            else
            {
                rb.AddForce(new Vector2(0, force_air));
            }
        }







        //if (Input.GetButtonDown("Jump")&& ground.grounded)
        //{
        //    rb.AddForce(new Vector2(0, force));
        //}
    }
}
