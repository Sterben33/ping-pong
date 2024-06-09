using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool keyPressed = false;
        if (Input.GetKey(KeyCode.W)) {
            keyPressed = true;
            rb.velocity = new(rb.velocity.x, +speed);
        }
        if (Input.GetKey(KeyCode.S)) {
            keyPressed = true;
            rb.velocity = new(rb.velocity.x, -speed);
        }
        if (!keyPressed) {
            rb.velocity = Vector2.zero;
        }
    }
}
