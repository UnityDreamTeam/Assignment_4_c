using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Transform velocity;
    public Rigidbody2D rb;
    float speed;
    private void Start()
    {
        speed = 700f;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * speed);
    }


    private void Update()
    {

    }

    public void setVelocity(Vector3 t)
    {
        rb.velocity = t;

    }
}
