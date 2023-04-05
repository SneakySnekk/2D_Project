using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.Space))
        if (Input.GetButton("Jump"))
        
        rb.AddForce (transform.up*5);

        //rb.AddForce (New.vector2(0,30));


    //float xInput = Input.GetAxisRaw("Horizontal");
    gameObject.transform.Rotate(0, 0, -Input.GetAxis("Horizontal"));
    //float yInput = Input.GetAxisRaw("Vertical");

   // gameObject.transform.Translate(new Vector3(xInput * Time.deltaTime, yInput * Time.deltaTime));

        //if (Input.GetAxis(""));
    
    
    
    }
}
