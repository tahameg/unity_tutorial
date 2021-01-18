using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_component : MonoBehaviour
{
    public float rotationSpeed;

    public int puan = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed);
    }
}
