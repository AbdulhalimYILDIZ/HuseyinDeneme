using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed,jumpForce;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(moveSpeed*Time.deltaTime,0,0));
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
        }
    }
}
