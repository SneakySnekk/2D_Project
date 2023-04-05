using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        if (Input.GetButtonDown("Fire1"))
        gameObject.GetComponent<Renderer>().material.color = Color.red;

        if (Input.GetButtonUp("Fire1"))
        gameObject.GetComponent<Renderer>().material.color = Color.black;
        

        
    }
}
