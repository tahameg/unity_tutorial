using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_sphere : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2.0f;
    public int puan = 0;
    public float jumpForce = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!rb)
        {
            Debug.Log("This object doesn't have a rigidbody!");
            enabled = false;
            return;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0.0f, 0.0f, 1.0f)*speed);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0.0f, 0.0f, -1.0f)*speed);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-1.0f, 0.0f, 0.0f)*speed);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(1.0f, 0.0f, 0.0f)*speed);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0.0f, 1.0f, 0.0f)*jumpForce);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        food_component fc = other.transform.GetComponent<food_component>();
        if (fc)
        {
            puan += fc.puan;
            transform.localScale = transform.localScale + new Vector3(1.0f, 1.0f, 1.0f) * (fc.puan / 10); 
            Destroy(other.gameObject);
        }
    }
    
}
