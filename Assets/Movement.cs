using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;
    Rigidbody physics;

    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }

    void Update()
    {
        physics.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")) * speed);
    }
}
