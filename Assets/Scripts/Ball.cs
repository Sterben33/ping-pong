using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        float speedUp = (1 + .05f * Time.deltaTime);
        rb.velocity = new(rb.velocity.x * speedUp, rb.velocity.y * speedUp);
        if(Math.Abs(rb.velocity.x) < 0.5) {
            rb.velocity = new(3, rb.velocity.y);
        }
    }

    public void Reset() {
        transform.position = Vector3.zero;
        rb.velocity = new(UnityEngine.Random.Range(-speed, speed), UnityEngine.Random.Range(-speed / 3, speed / 3));
    }
}
